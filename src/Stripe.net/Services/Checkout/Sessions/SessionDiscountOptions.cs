// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/coupons">Coupon</a> to apply to this
        /// Session. One of <c>coupon</c> or <c>coupon_data</c> is required when updating discounts.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/coupon">Coupon</a>
        /// object inline. One of <c>coupon</c> or <c>coupon_data</c> is required when updating
        /// discounts.
        /// </summary>
        [JsonProperty("coupon_data")]
        [STJS.JsonPropertyName("coupon_data")]
        public SessionDiscountCouponDataOptions CouponData { get; set; }

        /// <summary>
        /// The ID of a promotion code to apply to this Session.
        /// </summary>
        [JsonProperty("promotion_code")]
        [STJS.JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
