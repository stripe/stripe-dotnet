using System;
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
        internal string ProrationDateInternal
        {
            get
            {
                if (ProrationDate.HasValue)
                    return EpochTime.ConvertDateTimeToEpoch(ProrationDate.Value).ToString();
                else
                    return null;
            }
        }
    }
}