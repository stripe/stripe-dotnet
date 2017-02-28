using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeSubscriptionItem : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; } = "subscription_item";

        [JsonProperty("created")]
        public int? Created { get; set; }
        [JsonProperty("plan")]
        public StripePlan Plan { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }


    }
}
