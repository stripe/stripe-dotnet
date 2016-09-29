using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionCreateOptions : SubscriptionSharedOptions
    {
        public DateTime? BillingCycleAnchor { get; set; }
        public bool BillingCycleAnchorNow { get; set; }
        public bool BillingCycleAnchorUnchanged { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        internal string BillingCycleAnchorInternal
        {
            get
            {
                if (BillingCycleAnchorNow)
                    return "now";
                else if (BillingCycleAnchorUnchanged)
                    return "unchanged";
                else if (BillingCycleAnchor.HasValue)
                    return EpochTime.ConvertDateTimeToEpoch(BillingCycleAnchor.Value).ToString();
                else
                    return null;
            }
        }
    }
}