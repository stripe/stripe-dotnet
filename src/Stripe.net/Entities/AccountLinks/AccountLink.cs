// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Account Links are the means by which a Connect platform grants a connected account
    /// permission to access Stripe-hosted applications, such as Connect Onboarding.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/connect/custom/hosted-onboarding">Connect Onboarding</a>.
    /// </summary>
    public class AccountLink : StripeEntity<AccountLink>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp at which this account link will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the account link.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
