namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionBillingThresholdsOptions : INestedOptions
    {
        /// <summary>
        /// Monetary threshold that triggers the subscription to advance to a new billing period.
        /// </summary>
        [JsonProperty("amount_gte")]
        public long? AmountGte { get; set; }

        /// <summary>
        /// Indicates if the <code>billing_reason</code>  should be reset when a threshold is
        /// reached. If true, <code>billing_reason</code>  will be updated to the date/time the
        /// threshold was last reached; otherwise, the value will remain unchanged.
        /// </summary>
        [JsonProperty("reset_billing_cycle_anchor")]
        public bool? ResetBillingCycleAnchor { get; set; }
    }
}
