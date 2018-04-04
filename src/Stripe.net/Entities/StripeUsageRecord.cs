using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeUsageRecord : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}