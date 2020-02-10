namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderReturnItemOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
