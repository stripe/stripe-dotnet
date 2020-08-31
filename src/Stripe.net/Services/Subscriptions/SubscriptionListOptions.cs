namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodStart { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
