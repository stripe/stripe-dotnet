namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UsageRecordSummary : StripeEntity<UsageRecordSummary>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("invoice")]
        public string InvoiceId { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("subscription_item")]
        public string SubscriptionItemId { get; set; }

        [JsonProperty("total_usage")]
        public long TotalUsage { get; set; }
    }
}
