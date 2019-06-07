namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionUpdateOptions : SubscriptionSharedOptions
    {
        /// <summary>
        /// One of <see cref="SubscriptionBillingCycleAnchor"/>. Setting the value to
        /// <see cref="SubscriptionBillingCycleAnchor.Now"/> resets the subscription’s billing
        /// cycle anchor to the current time. For more information, see the billing cycle
        /// <a href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public SubscriptionBillingCycleAnchor? BillingCycleAnchor { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan.
        /// </summary>
        [JsonProperty("items")]
        public List<SubscriptionItemUpdateOption> Items { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the given time. This can be used to apply exactly the same proration that was previewed with <see href="https://stripe.com/docs/api#upcoming_invoice">upcoming invoice</see> endpoint. It can also be used to implement custom proration logic, such as prorating by day instead of by second, by providing the time that you wish to use for proration calculations.
        /// </summary>
        [JsonProperty("proration_date")]
        public DateTime? ProrationDate { get; set; }
    }
}
