namespace Stripe
{
    using System;
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif
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
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("object")]
#else
        [JsonProperty("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#else
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp at which this account link will expire.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#else
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the account link.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("url")]
#else
        [JsonProperty("url")]
#endif
        public string Url { get; set; }
    }
}
