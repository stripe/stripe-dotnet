namespace Stripe
{
    using System.Net;
    using System.Net.Http.Headers;

    /// <summary>
    /// Represents a buffered textual response from Stripe's API.
    /// </summary>
    public class StripeResponse : StripeResponseBase
    {
        /// <summary>Initializes a new instance of the <see cref="StripeResponse"/> class.</summary>
        /// <param name="statusCode">The HTTP status code.</param>
        /// <param name="headers">The HTTP headers of the response.</param>
        /// <param name="content">The body of the response.</param>
        public StripeResponse(HttpStatusCode statusCode, HttpResponseHeaders headers, string content)
            : base(statusCode, headers)
        {
            this.Content = content;
        }

        /// <summary>Gets the body of the response.</summary>
        /// <value>The body of the response.</value>
        public string Content { get; }
    }
}
