namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemDeleteOptions : BaseOptions
    {
        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ProrationDate { get; set; }
    }
}
