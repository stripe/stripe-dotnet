using System;
using System.Collections.Generic;
using Stripe.Infrastructure;
using Newtonsoft.Json; 

namespace Stripe
{
    public class StripeInventory : StripeEntity
    {
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
