// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemBillingThresholdsOptions : INestedOptions
    {
        /// <summary>
        /// Number of units that meets the billing threshold to advance the subscription to a new
        /// billing period (e.g., it takes 10 $5 units to meet a $50 <a
        /// href="https://stripe.com/docs/api/subscriptions/update#update_subscription-billing_thresholds-amount_gte">monetary
        /// threshold</a>).
        /// </summary>
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
