// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineActionSetDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The coupon code to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// An ID of an existing discount to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
#endif
        public string Discount { get; set; }

        /// <summary>
        /// An ID of an existing promotion code to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("promotion_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotion_code")]
#endif
        public string PromotionCode { get; set; }

        /// <summary>
        /// Settings for discount application including service period anchoring.
        /// </summary>
        [JsonProperty("settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settings")]
#endif
        public QuoteLineActionSetDiscountSettingsOptions Settings { get; set; }
    }
}
