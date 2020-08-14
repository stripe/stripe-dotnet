namespace Stripe
{
    using Newtonsoft.Json;

    public class UsageRecordSummary : StripeEntity<UsageRecordSummary>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The invoice in which this usage period has been billed for.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("period")]
        public UsageRecordSummaryPeriod Period { get; set; }

        /// <summary>
        /// The ID of the subscription item this summary is describing.
        /// </summary>
        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }

        /// <summary>
        /// The total usage within this usage period.
        /// </summary>
        [JsonProperty("total_usage")]
        public long TotalUsage { get; set; }
    }
}
