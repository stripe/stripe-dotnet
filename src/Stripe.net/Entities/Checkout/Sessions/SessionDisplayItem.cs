namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionDisplayItem : StripeEntity<SessionDisplayItem>
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("custom")]
        public SessionDisplayItemCustom Custom { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("sku")]
        public Sku Sku { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
