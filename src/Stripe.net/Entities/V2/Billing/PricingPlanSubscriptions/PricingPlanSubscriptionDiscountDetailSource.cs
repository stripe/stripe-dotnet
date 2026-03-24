// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionDiscountDetailSource : StripeEntity<PricingPlanSubscriptionDiscountDetailSource>
    {
        /// <summary>
        /// The ID of the Coupon.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Type of the Discount source.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
