// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplyDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Coupon to apply.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The ID of the PromotionCode to apply.
        /// </summary>
        [JsonProperty("promotion_code")]
        [STJS.JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// Type of the discount.
        /// One of: <c>coupon</c>, or <c>promotion_code</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
