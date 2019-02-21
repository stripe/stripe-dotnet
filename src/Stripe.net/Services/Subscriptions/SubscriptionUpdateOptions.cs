namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionUpdateOptions : SubscriptionSharedOptions
    {
        #region BillingCycleAnchor
        [JsonIgnore]
        public bool BillingCycleAnchorNow { get; set; }

        [JsonIgnore]
        public bool BillingCycleAnchorUnchanged { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        internal string BillingCycleAnchorInternal
        {
            get
            {
                if (this.BillingCycleAnchorNow)
                {
                    return "now";
                }

                if (this.BillingCycleAnchorUnchanged)
                {
                    return "unchanged";
                }

                return null;
            }
        }
        #endregion

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
