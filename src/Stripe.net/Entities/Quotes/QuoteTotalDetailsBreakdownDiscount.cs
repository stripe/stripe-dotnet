// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteTotalDetailsBreakdownDiscount : StripeEntity<QuoteTotalDetailsBreakdownDiscount>
    {
        /// <summary>
        /// The amount discounted.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
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
        [STJS.JsonPropertyName("discount")]
        public Discount Discount { get; set; }
    }
}
