// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteComputedRecurringTotalDetailsBreakdownDiscount : StripeEntity<QuoteComputedRecurringTotalDetailsBreakdownDiscount>
    {
        /// <summary>
        /// The amount discounted.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// A discount represents the actual application of a coupon to a particular customer. It
        /// contains information about when the discount began and when it will end.
        ///
        /// Related guide: <a
        /// href="https://stripe.com/docs/billing/subscriptions/discounts">Applying Discounts to
        /// Subscriptions</a>.
        /// </summary>
        [JsonProperty("discount")]
        public Discount Discount { get; set; }
    }
}
