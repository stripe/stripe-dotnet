namespace Stripe
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http.Headers;

    /// <summary>
    /// Represents a response from Stripe's API.
    /// </summary>
    public abstract class StripeResponseBase
    {
        /// <summary>Initializes a new instance of the <see cref="StripeResponseBase"/> class.</summary>
        /// <param name="statusCode">The HTTP status code.</param>
        /// <param name="headers">The HTTP headers of the response.</param>
        public StripeResponseBase(HttpStatusCode statusCode, HttpResponseHeaders headers)
        {
            this.StatusCode = statusCode;
            this.Headers = headers;
        }

        /// <summary>Gets the HTTP status code of the response.</summary>
        /// <value>The HTTP status code of the response.</value>
        public HttpStatusCode StatusCode { get; }

        /// <summary>Gets the HTTP headers of the response.</summary>
        /// <value>The HTTP headers of the response.</value>
        public HttpResponseHeaders Headers { get; }

        /// <summary>Gets the date of the request, as returned by Stripe.</summary>
        /// <value>The date of the request, as returned by Stripe.</value>
        public DateTimeOffset? Date => this.Headers?.Date;

        /// <summary>Gets the idempotency key of the request, as returned by Stripe.</summary>
        /// <value>The idempotency key of the request, as returned by Stripe.</value>
        public string IdempotencyKey => MaybeGetHeader(this.Headers, "Idempotency-Key");

        /// <summary>Gets the ID of the request, as returned by Stripe.</summary>
        /// <value>The ID of the request, as returned by Stripe.</value>
        public string RequestId => MaybeGetHeader(this.Headers, "Request-Id");

        internal int NumRetries { get; set; }

        /// <summary>Returns a string that represents the <see cref="StripeResponse"/>.</summary>
        /// <returns>A string that represents the <see cref="StripeResponse"/>.</returns>
        public override string ToString()
        {
            return string.Format(
                "<{0} status={1} Request-Id={2} Date={3}>",
                this.GetType().FullName,
                (int)this.StatusCode,
                this.RequestId,
                this.Date?.ToString("s"));
        }

        private static string MaybeGetHeader(HttpHeaders headers, string name)
        {
            if ((headers == null) || (!headers.Contains(name)))
            {
                return null;
            }

            return headers.GetValues(name).First();
        }
    }
}
