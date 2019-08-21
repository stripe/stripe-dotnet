namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UsageRecordCreateOptions : BaseOptions
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
