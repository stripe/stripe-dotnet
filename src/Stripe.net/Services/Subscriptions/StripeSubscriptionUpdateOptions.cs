using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionUpdateOptions : SubscriptionSharedOptions
    {
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        public DateTime? ProrationDate { get; set; }

        [JsonProperty("proration_date")]
        internal string ProrationDateInternal => ProrationDate?.ConvertDateTimeToEpoch().ToString();

        // this will actually send items. this is to flag it for the middleware
        // to process it as a plugin
        [JsonProperty("subscription_items_array_updated")]
        public List<StripeSubscriptionItemUpdateOption> Items { get; set; }
    }
}