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
        /// The ID of the <a href="https://stripe.com/docs/api/coupons">Coupon</a> to apply to this
        /// Session. One of <c>coupon</c> or <c>coupon_data</c> is required when updating discounts.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/coupon">Coupon</a>
        /// object inline. One of <c>coupon</c> or <c>coupon_data</c> is required when updating
        /// discounts.
        /// </summary>
        [JsonProperty("coupon_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon_data")]
#endif
        public SessionDiscountCouponDataOptions CouponData { get; set; }

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
