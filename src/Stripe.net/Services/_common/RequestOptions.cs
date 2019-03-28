namespace Stripe
{
    public class RequestOptions
    {
        /// <summary>The API key to use for the request.</summary>
        public string ApiKey { get; set; }

        /// <summary>Idempotency key for safely retrying requests.</summary>
        public string IdempotencyKey { get; set; }

        public string StripeConnectAccountId { get; set; }

        /// <summary>The base URL for the request.</summary>
        /// <remarks>
        /// This is an internal property. It is set by services or individual request methods when
        /// they need to send a request to a non-standard destination, e.g. <c>files.stripe.com</c>
        /// for file creation requests or <c>connect.stripe.com</c> for OAuth requests.
        /// </remarks>
        internal string BaseUrl { get; set; }

        /// <summary>The API version for the request.</summary>
        /// <remarks>
        /// This is an internal property. For most requests, the API version is always set to the
        /// library's pinned version (<see cref="StripeConfiguration.ApiVersion"/>). This property
        /// is only used for creating ephemeral keys, which require a specific API version.
        /// </remarks>
        internal string StripeVersion { get; set; }
    }
}
