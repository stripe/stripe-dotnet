// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionAfterExpirationRecovery : StripeEntity<SessionAfterExpirationRecovery>
    {
        /// <summary>
        /// Enables user redeemable promotion codes on the recovered Checkout Sessions. Defaults to
        /// <c>false</c>.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// If <c>true</c>, a recovery url will be generated to recover this Checkout Session if it
        /// expires before a transaction is completed. It will be attached to the Checkout Session
        /// object upon expiration.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The timestamp at which the recovery URL will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// URL that creates a new Checkout Session when clicked that is a copy of this expired
        /// Checkout Session.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
