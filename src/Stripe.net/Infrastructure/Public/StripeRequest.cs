namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using Stripe.Infrastructure.FormEncoding;

    /// <summary>
    /// Represents a request to Stripe's API.
    /// </summary>
    public class StripeRequest
    {
        // Either options or content can be set.
        // If content is set, it will be used instead of serialized options.
        private readonly BaseOptions options;
        private readonly string content;

        /// <summary>Initializes a new instance of the <see cref="StripeRequest"/> class.</summary>
        /// <param name="client">The client creating the request.</param>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="options">The parameters of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        public StripeRequest(
            IStripeClient client,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.options = options;

            this.Method = method;

            this.Uri = BuildUri(client.ApiBase, method, path, options, ApiMode.V1);

            this.AuthorizationHeader = BuildAuthorizationHeader(requestOptions?.ApiKey ?? client.ApiKey, requestOptions);

            this.StripeHeaders = BuildStripeHeaders(method, requestOptions, ApiMode.V1);

            this.Usage = requestOptions?.Usage;
        }

        /// <summary>Initializes a new instance of the <see cref="StripeRequest"/> class.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="uri">The full URI of the request.</param>
        /// <param name="options">The parameters of the request.</param>
        /// <param name="content">The string content of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="apiMode">The API mode of the request.</param>
        internal StripeRequest(
            HttpMethod method,
            Uri uri,
            RequestOptions requestOptions,
            BaseOptions options,
            string content,
            ApiMode apiMode)
        {
            this.options = options;
            this.content = content;
            this.ApiMode = apiMode;

            this.Method = method;

            this.Uri = uri;

            this.AuthorizationHeader = BuildAuthorizationHeader(requestOptions.ApiKey, requestOptions);

            this.StripeHeaders = BuildStripeHeaders(method, requestOptions, this.ApiMode);

            this.Usage = requestOptions?.Usage;
        }

        /// <summary>The HTTP method for the request (GET, POST or DELETE).</summary>
        public HttpMethod Method { get; }

        /// <summary>
        /// The URL for the request. If this is a GET or DELETE request, the URL also includes
        /// the request parameters in its query string.
        /// </summary>
        public Uri Uri { get; }

        /// <summary>The value of the <c>Authorization</c> header with the API key.</summary>
        public AuthenticationHeaderValue AuthorizationHeader { get; }

        /// <summary>
        /// Dictionary containing Stripe custom headers (<c>Stripe-Version</c>,
        /// <c>Stripe-Account</c>, <c>Idempotency-Key</c>...).
        /// </summary>
        public IDictionary<string, string> StripeHeaders { get; }

        /// <summary>
        /// The body of the request. For POST requests, this will be either a
        /// <c>application/x-www-form-urlencoded</c> or a <c>multipart/form-data</c> payload.
        /// For non-POST requests, this will be <c>null</c>.
        /// </summary>
        /// <remarks>This getter creates a new instance every time it is called.</remarks>
        public HttpContent Content => BuildContent(this.Method, this.options, this.content, this.ApiMode);

        internal ApiMode ApiMode { get; }

        internal List<string> Usage { get; }

        /// <summary>Initializes a new instance of the <see cref="StripeRequest"/> class.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="uri">The Uri of the request.</param>
        /// <param name="content">The body the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="apiMode">The API mode of the request.</param>
        /// <returns>Returns a new instance of the <see cref="StripeRequest"/> class.</returns>
        internal static StripeRequest CreateWithStringContent(
            HttpMethod method,
            Uri uri,
            string content,
            RequestOptions requestOptions,
            ApiMode apiMode)
        {
            return new StripeRequest(method, uri, requestOptions, null, content, apiMode);
        }

        /// <summary>Returns a string that represents the <see cref="StripeRequest"/>.</summary>
        /// <returns>A string that represents the <see cref="StripeRequest"/>.</returns>
        public override string ToString()
        {
            return string.Format(
                "<{0} Method={1} Uri={2}>",
                this.GetType().FullName,
                this.Method,
                this.Uri.ToString());
        }

        internal static Uri BuildUri(
            string baseUrl,
            HttpMethod method,
            string path,
            BaseOptions options,
            ApiMode apiMode)
        {
            var b = new StringBuilder();

            b.Append(baseUrl);
            b.Append(path);

            if ((method != HttpMethod.Post) && (options != null))
            {
                var queryString = ContentEncoder.CreateQueryString(options, apiMode);
                if (!string.IsNullOrEmpty(queryString))
                {
                    b.Append("?");
                    b.Append(queryString);
                }
            }

            return new Uri(b.ToString());
        }

        private static AuthenticationHeaderValue BuildAuthorizationHeader(
            string apiKey,
            RequestOptions requestOptions)
        {
            if (apiKey == null)
            {
                var message = "No API key provided. Set your API key using "
                    + "`var client = new Stripe.StripeClient(\"<API-KEY>\")`."
                    + "You can generate API keys from the Stripe Dashboard. See "
                    + "https://stripe.com/docs/api/authentication for details or contact support "
                    + "at https://support.stripe.com/email if you have any questions.";
                throw new StripeException(message);
            }

            return new AuthenticationHeaderValue("Bearer", apiKey);
        }

        private static Dictionary<string, string> BuildStripeHeaders(
            HttpMethod method,
            RequestOptions requestOptions,
            ApiMode apiMode)
        {
            var stripeHeaders = new Dictionary<string, string>
            {
                { "Stripe-Version", requestOptions?.StripeVersion ?? StripeConfiguration.ApiVersion },
            };

            if (!string.IsNullOrEmpty(requestOptions?.StripeAccount))
            {
                stripeHeaders.Add("Stripe-Account", requestOptions.StripeAccount);
            }

            if (!string.IsNullOrEmpty(requestOptions?.StripeContext))
            {
                stripeHeaders.Add("Stripe-Context", requestOptions.StripeContext);
            }

            if (!string.IsNullOrEmpty(requestOptions?.IdempotencyKey))
            {
                stripeHeaders.Add("Idempotency-Key", requestOptions.IdempotencyKey);
            }
            else if (method == HttpMethod.Post || (apiMode == ApiMode.V2 && method == HttpMethod.Delete))
            {
                stripeHeaders.Add("Idempotency-Key", Guid.NewGuid().ToString());
            }

            if (requestOptions is RawRequestOptions rawRequestOptions)
            {
                foreach (KeyValuePair<string, string> item in rawRequestOptions.AdditionalHeaders)
                {
                    stripeHeaders[item.Key] = item.Value;
                }
            }

            return stripeHeaders;
        }

        internal static HttpContent BuildContent(HttpMethod method, BaseOptions options, string content, ApiMode apiMode)
        {
            if (method != HttpMethod.Post)
            {
                return null;
            }

            if (content != null)
            {
                if (apiMode == ApiMode.V2)
                {
                    return new StringContent(content)
                    {
                        Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                            {
                                CharSet = "utf-8",
                            },
                        },
                    };
                }

                return new StringContent(content)
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded")
                        {
                            CharSet = "utf-8",
                        },
                    },
                };
            }

            return ContentEncoder.CreateHttpContent(options, apiMode);
        }
    }
}
