// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteTotalDetailsBreakdownDiscount : StripeEntity<QuoteTotalDetailsBreakdownDiscount>
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
        /// href="https://stripe.com/docs/api#coupons">coupon</a> or <a
        /// href="https://stripe.com/docs/api#promotion_codes">promotion code</a>. It contains
        /// information about when the discount began, when it will end, and what it is applied to.
        ///
        /// Related guide: <a
        /// href="https://stripe.com/docs/billing/subscriptions/discounts">Applying discounts to
        /// subscriptions</a>.
        /// </summary>
        [JsonProperty("discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
#endif
        public Discount Discount { get; set; }
    }
}
