using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionUpdateOptions : SubscriptionSharedOptions
    {
        #region BillingCycleAnchor
        public bool BillingCycleAnchorNow { get; set; }
        public bool BillingCycleAnchorUnchanged { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        internal string BillingCycleAnchorInternal
        {
            get
            {
                if (BillingCycleAnchorNow)
                    return "now";

                if (BillingCycleAnchorUnchanged)
                    return "unchanged";

                return null;
            }
        }
        #endregion

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the given time. This can be used to apply exactly the same proration that was previewed with <see href="https://stripe.com/docs/api#upcoming_invoice">upcoming invoice</see> endpoint. It can also be used to implement custom proration logic, such as prorating by day instead of by second, by providing the time that you wish to use for proration calculations.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan.
        /// </summary>
        // this will actually send `items`. this is to flag it for the middleware
        // to process it as a plugin
        [JsonProperty("subscription_items_array_updated")]
        public List<StripeSubscriptionItemUpdateOption> Items { get; set; }

        #region ProrationDate
        /// <summary>
        /// Boolean indicating whether this subscription should cancel at the end of the current period.
        /// </summary>
        public DateTime? ProrationDate { get; set; }

        [JsonProperty("proration_date")]
        internal string ProrationDateInternal => ProrationDate?.ConvertDateTimeToEpoch().ToString();
        #endregion
    }
}
