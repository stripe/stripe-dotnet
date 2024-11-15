// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionAfterExpirationRecoveryOptions : INestedOptions
    {
        /// <summary>
        /// Enables user redeemable promotion codes on the recovered Checkout Sessions. Defaults to
        /// <c>false</c>.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_promotion_codes")]
#endif

        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// If <c>true</c>, a recovery URL will be generated to recover this Checkout Session if it
        /// expires before a successful transaction is completed. It will be attached to the
        /// Checkout Session object upon expiration.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif

        public bool? Enabled { get; set; }
    }
}
