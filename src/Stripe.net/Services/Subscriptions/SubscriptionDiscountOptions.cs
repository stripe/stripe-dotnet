// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionDiscountOptions : INestedOptions
    {
        /// <summary>
        /// ID of the coupon to create a new discount for.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// ID of an existing discount on the object (or one of its ancestors) to reuse.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// ID of the promotion code to create a new discount for.
        /// </summary>
        [JsonProperty("promotion_code")]
        [STJS.JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
