// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderTotalDetailsBreakdownDiscount : StripeEntity<OrderTotalDetailsBreakdownDiscount>
    {
        /// <summary>
        /// The amount discounted.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// A discount represents the actual application of a <a
        /// href="https://api.stripe.com#coupons">coupon</a> or <a
        /// href="https://api.stripe.com#promotion_codes">promotion code</a>. It contains
        /// information about when the discount began, when it will end, and what it is applied to.
        ///
        /// Related guide: <a
        /// href="https://docs.stripe.com/billing/subscriptions/discounts">Applying discounts to
        /// subscriptions</a>.
        /// </summary>
        [JsonProperty("discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
#endif
        public Discount Discount { get; set; }
    }
}
