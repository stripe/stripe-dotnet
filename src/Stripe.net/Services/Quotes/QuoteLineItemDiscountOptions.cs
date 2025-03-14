// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineItemDiscountOptions : INestedOptions
    {
        /// <summary>
        /// ID of the coupon to create a new discount for.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// ID of an existing discount on the object (or one of its ancestors) to reuse.
        /// </summary>
        [JsonProperty("discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
#endif
        public string Discount { get; set; }

        /// <summary>
        /// Details to determine how long the discount should be applied for.
        /// </summary>
        [JsonProperty("discount_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_end")]
#endif
        public QuoteLineItemDiscountDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// ID of the promotion code to create a new discount for.
        /// </summary>
        [JsonProperty("promotion_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotion_code")]
#endif
        public string PromotionCode { get; set; }
    }
}
