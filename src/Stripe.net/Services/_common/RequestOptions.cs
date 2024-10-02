namespace Stripe
{
    using System;
    using System.Collections.Generic;

    public class RequestOptions
    {
        /// <summary>
        /// Gets or sets the <a href="https://stripe.com/docs/api/authentication?lang=dotnet">API
        /// key</a> to use for the request.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Get or sets the <a href="https://stripe.com/docs/api/idempotent_requests">idempotency
        /// key</a> to use for the request.
        /// </summary>
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// Get or sets the
        /// <a href="https://stripe.com/docs/connect/authentication#authentication-via-the-stripe-account-header">ID
        /// of the connected account</a> to use for the request.
        /// </summary>
        public string StripeAccount { get; set; }

        /// <summary>Gets or sets the base URL for the request.</summary>
        /// <remarks>
        /// This is an internal property. It is set by services or individual request methods when
        /// they need to send a request to a non-standard destination, e.g. <c>files.stripe.com</c>
        /// for file creation requests or <c>connect.stripe.com</c> for OAuth requests.
        /// </remarks>
        internal string BaseUrl { get; set; }

        /// <summary>Gets or sets the API version for the request.</summary>
        /// <remarks>
        /// This is an internal property. For most requests, the API version is always set to the
        /// library's pinned version (<see cref="StripeConfiguration.ApiVersion"/>). This property
        /// is only used for creating ephemeral keys, which require a specific API version.
        /// </remarks>
        internal string StripeVersion { get; set; }

        /// <summary>Tracked behaviors.</summary>
        /// <remarks>
        /// This is an internal property for use only by the Stripe.net library.
        /// Its interface is unstable and subject to change or removal.
        /// </remarks>
        internal List<string> Usage { get; set; }

        internal RequestOptions Clone()
        {
            return (RequestOptions)this.MemberwiseClone();
        }
    }

#pragma warning disable SA1402 // FileMayOnlyContainASingleType
    internal static class RequestOptionsExtensions
    {
        internal static T WithUsage<T>(this T options, List<string> usage)
            where T : RequestOptions, new()
        {
            if (options == null)
            {
                return new T() { Usage = usage };
            }

            var clone = (T)options.Clone();
            clone.Usage = usage;
            return clone;
        }
    }
#pragma warning restore SA1402 // FileMayOnlyContainASingleType
}
