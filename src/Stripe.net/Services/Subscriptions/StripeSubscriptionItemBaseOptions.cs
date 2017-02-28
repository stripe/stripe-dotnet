using Newtonsoft.Json;
using System;

namespace Stripe
{
    public abstract class StripeSubscriptionItemBaseChangeOptions
    {
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        [JsonProperty("proration_date")]
        public DateTime? ProrationDate { get; set; }
    }
}
