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

        [JsonIgnore]
        public string SubscriptionItem { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
