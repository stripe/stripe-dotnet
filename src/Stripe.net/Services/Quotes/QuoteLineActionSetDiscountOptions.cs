// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteLineActionSetDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The coupon code to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// An ID of an existing discount to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// An ID of an existing promotion code to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("promotion_code")]
        [STJS.JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// Settings for discount application including service period anchoring.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public QuoteLineActionSetDiscountSettingsOptions Settings { get; set; }
    }
}
