using Newtonsoft.Json;
using Stripe.Infrastructure;
using System;

namespace Stripe
{
    public abstract class StripeSubscriptionItemBaseChangeOptions
    {
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        [JsonProperty("proration_date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }
    }
}
