// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineActionAddDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The coupon code to redeem.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// An ID of an existing discount for a coupon that was already redeemed.
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
        public QuoteLineActionAddDiscountDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// The index, starting at 0, at which to position the new discount. When not supplied,
        /// Stripe defaults to appending the discount to the end of the <c>discounts</c> array.
        /// </summary>
        [JsonProperty("index")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("index")]
#endif
        public long? Index { get; set; }

        /// <summary>
        /// The promotion code to redeem.
        /// </summary>
        [JsonProperty("promotion_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotion_code")]
#endif
        public string PromotionCode { get; set; }
    }
}
