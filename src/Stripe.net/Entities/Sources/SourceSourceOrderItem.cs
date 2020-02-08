namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceSourceOrderItem : StripeEntity<SourceSourceOrderItem>
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
