// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PromotionCodeRestrictionsCurrencyOptions : StripeEntity<PromotionCodeRestrictionsCurrencyOptions>
    {
        /// <summary>
        /// Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase
        /// must be $100 or more to work).
        /// </summary>
        [JsonProperty("minimum_amount")]
        [STJS.JsonPropertyName("minimum_amount")]
        public long MinimumAmount { get; set; }
    }
}
