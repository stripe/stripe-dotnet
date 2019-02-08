namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using Stripe.Infrastructure.Extensions;
    using Stripe.Infrastructure.FormEncoding;

    /// <summary>
    /// Represents a request to Stripe's API.
    /// </summary>
    public class Request
    {
        /// <summary>Initializes a new instance of the <see cref="Request"/> class.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="options">The parameters of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        public Request(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            this.Method = method;

            this.Uri = BuildUri(method, path, options, requestOptions);

            this.AuthorizationHeader = new AuthenticationHeaderValue(
                "Bearer",
                requestOptions?.ApiKey ?? StripeConfiguration.ApiKey);

            this.StripeHeaders = BuildStripeHeaders(requestOptions);

            this.Content = BuildContent(method, options);
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
        public HttpContent Content { get; }

        private static Uri BuildUri(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            var b = new StringBuilder();

            b.Append(requestOptions?.BaseUrl ?? StripeConfiguration.ApiBase);
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

        private static Dictionary<string, string> BuildStripeHeaders(RequestOptions requestOptions)
        {
            var stripeHeaders = new Dictionary<string, string>
            {
                { "Stripe-Version", requestOptions?.StripeVersion ?? StripeConfiguration.ApiVersion },
            };

            if (!string.IsNullOrEmpty(requestOptions?.StripeConnectAccountId))
            {
                stripeHeaders.Add("Stripe-Account", requestOptions.StripeConnectAccountId);
            }

            if (!string.IsNullOrEmpty(requestOptions?.IdempotencyKey))
            {
                stripeHeaders.Add("Idempotency-Key", requestOptions.IdempotencyKey);
            }

            return stripeHeaders;
        }

        private static HttpContent BuildContent(HttpMethod method, BaseOptions options)
        {
            if (method != HttpMethod.Post)
            {
                return null;
            }

            return FormEncoder.CreateHttpContent(options);
        }
    }
}
