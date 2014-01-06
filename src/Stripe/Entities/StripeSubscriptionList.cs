using System.Collections.Generic;

using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionList
    {
        public StripeSubscriptionList()
        {
            StripeSubscriptions = new List<StripeSubscription>();
        }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("data")]
        public List<StripeSubscription> StripeSubscriptions { get; set; } 
    }
}