// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the coupon to apply to this Session.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// The ID of a promotion code to apply to this Session.
        /// </summary>
        [JsonProperty("promotion_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotion_code")]
#endif
        public string PromotionCode { get; set; }
    }
}
