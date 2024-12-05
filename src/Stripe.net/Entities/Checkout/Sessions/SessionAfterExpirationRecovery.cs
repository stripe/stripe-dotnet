// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionAfterExpirationRecovery : StripeEntity<SessionAfterExpirationRecovery>
    {
        /// <summary>
        /// Enables user redeemable promotion codes on the recovered Checkout Sessions. Defaults to
        /// <c>false</c>.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_promotion_codes")]
#endif
        public bool AllowPromotionCodes { get; set; }

        /// <summary>
        /// If <c>true</c>, a recovery url will be generated to recover this Checkout Session if it
        /// expires before a transaction is completed. It will be attached to the Checkout Session
        /// object upon expiration.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// The timestamp at which the recovery URL will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// URL that creates a new Checkout Session when clicked that is a copy of this expired
        /// Checkout Session.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
