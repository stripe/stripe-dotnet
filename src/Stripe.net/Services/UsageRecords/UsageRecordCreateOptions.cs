namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UsageRecordCreateOptions : BaseOptions
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
