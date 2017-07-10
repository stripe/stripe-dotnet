using System;
using System.Collections.Generic;
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

                if (BillingCycleAnchorUnchanged)
                    return "unchanged";

                return BillingCycleAnchor?.ConvertDateTimeToEpoch().ToString();
            }
        }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        // this will actually send items. this is to flag it for the middleware
        // to process it as a plugin
        [JsonProperty("subscription_items_array")]
        public List<StripeSubscriptionItemOption> Items { get; set; }
    }
}