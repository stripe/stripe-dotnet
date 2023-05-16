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
        // Either options os content can be set.
        // If content is set, it will be used instead of serialized options.
        private readonly BaseOptions options;
        private readonly string content;
        private readonly ApiMode apiMode;

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

            this.Uri = BuildUri(client, method, path, options, requestOptions);

            this.AuthorizationHeader = BuildAuthorizationHeader(client, requestOptions);

            this.apiMode = requestOptions is RawRequestOptions rawRequestOptions ? rawRequestOptions.ApiMode : ApiMode.Standard;

            this.StripeHeaders = BuildStripeHeaders(method, requestOptions, this.apiMode);
        }

        /// <summary>Initializes a new instance of the <see cref="StripeRequest"/> class.</summary>
        /// <param name="client">The client creating the request.</param>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        private StripeRequest(
            IStripeClient client,
            HttpMethod method,
            string path,
            string content,
            RequestOptions requestOptions)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.content = content;

            this.Method = method;

            this.Uri = BuildUri(client, method, path, null, requestOptions);

            this.AuthorizationHeader = BuildAuthorizationHeader(client, requestOptions);

            this.apiMode = requestOptions is RawRequestOptions rawRequestOptions ? rawRequestOptions.ApiMode : ApiMode.Standard;

            this.StripeHeaders = BuildStripeHeaders(method, requestOptions, this.apiMode);
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
        public HttpContent Content => this.BuildContent();

        /// <summary>Initializes a new instance of the <see cref="StripeRequest"/> class.</summary>
        /// <param name="client">The client creating the request.</param>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <returns>Returns a new instance of the <see cref="StripeRequest"/> class.</returns>
        internal static StripeRequest CreateWithStringContent(
            IStripeClient client,
            HttpMethod method,
            string path,
            string content,
            RequestOptions requestOptions)
        {
            return new StripeRequest(client, method, path, content, requestOptions);
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

        private static Uri BuildUri(
            IStripeClient client,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            var b = new StringBuilder();

            b.Append(requestOptions?.BaseUrl ?? client.ApiBase);
            b.Append(path);

            if ((method != HttpMethod.Post) && (options != null))
            {
                var queryString = FormEncoder.CreateQueryString(options);
                if (!string.IsNullOrEmpty(queryString))
                {
                    b.Append("?");
                    b.Append(queryString);
                }
            }

            return new Uri(b.ToString());
        }

        private static AuthenticationHeaderValue BuildAuthorizationHeader(
            IStripeClient client,
            RequestOptions requestOptions)
        {
            string apiKey = requestOptions?.ApiKey ?? client.ApiKey;

            if (apiKey == null)
            {
                var message = "No API key provided. Set your API key using "
                    + "`StripeConfiguration.ApiKey = \"<API-KEY>\"`. You can generate API keys "
                    + "from the Stripe Dashboard. See "
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
            string defaultVersion =
                apiMode == ApiMode.Standard ? StripeConfiguration.ApiVersion : ApiVersion.CurrentPreview;

            var stripeHeaders = new Dictionary<string, string>
            {
                { "Stripe-Version", requestOptions?.StripeVersion ?? defaultVersion },
            };

            if (!string.IsNullOrEmpty(requestOptions?.StripeAccount))
            {
                stripeHeaders.Add("Stripe-Account", requestOptions.StripeAccount);
            }

            if (!string.IsNullOrEmpty(requestOptions?.IdempotencyKey))
            {
                stripeHeaders.Add("Idempotency-Key", requestOptions.IdempotencyKey);
            }
            else if (method == HttpMethod.Post)
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

        private HttpContent BuildContent()
        {
            if (this.Method != HttpMethod.Post)
            {
                return null;
            }

            if (this.apiMode == ApiMode.Preview)
            {
                string serializedContent = this.content ?? Newtonsoft.Json.JsonConvert.SerializeObject(this.options);

                return new StringContent(serializedContent)
                {
                    Headers = { ContentType = new MediaTypeHeaderValue("application/json") },
                };
            }

            return this.content != null ? new StringContent(this.content)
            {
                Headers = { ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded") { CharSet = "utf-8" } },
            }
            : FormEncoder.CreateHttpContent(this.options);
        }
    }
}
