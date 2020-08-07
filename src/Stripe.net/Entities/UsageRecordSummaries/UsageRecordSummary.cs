namespace Stripe
{
    using Newtonsoft.Json;

    public class UsageRecordSummary : StripeEntity<UsageRecordSummary>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("period")]
        public UsageRecordSummaryPeriod Period { get; set; }

        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }

        [JsonProperty("total_usage")]
        public long TotalUsage { get; set; }
    }
}
