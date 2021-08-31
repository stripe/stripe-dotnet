// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionAfterExpirationRecoveryOptions : INestedOptions
    {
        /// <summary>
        /// Enables user redeemable promotion codes on the recovered Checkout Sessions. Defaults to
        /// <c>false</c>.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// If <c>true</c>, a recovery url will be generated to recover this Checkout Session if it
        /// expires before a successful transaction is completed. It will be attached to the
        /// Checkout Session object upon expiration.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
