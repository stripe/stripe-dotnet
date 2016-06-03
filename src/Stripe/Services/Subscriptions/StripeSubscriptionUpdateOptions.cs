using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSubscriptionUpdateOptions : StripeSubscriptionCreateOptions
    {
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}