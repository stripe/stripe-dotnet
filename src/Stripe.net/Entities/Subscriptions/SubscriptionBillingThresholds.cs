namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionBillingThresholds : StripeEntity<SubscriptionBillingThresholds>
    {
        /// <summary>
        /// Monetary threshold that triggers the subscription to create an invoice.
        /// </summary>
        [JsonProperty("amount_gte")]
        public long? AmountGte { get; set; }

        /// <summary>
        /// Indicates if the <c>billing_cycle_anchor</c> should be reset when a threshold is
        /// reached. If true, <c>billing_cycle_anchor</c> will be updated to the date/time the
        /// threshold was last reached; otherwise, the value will remain unchanged. This value may
        /// not be <c>true</c> if the subscription contains items with plans that have
        /// <c>aggregate_usage=last_ever</c>.
        /// </summary>
        [JsonProperty("reset_billing_cycle_anchor")]
        public bool? ResetBillingCycleAnchor { get; set; }
    }
}
