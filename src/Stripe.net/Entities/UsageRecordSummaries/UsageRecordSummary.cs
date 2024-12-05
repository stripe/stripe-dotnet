// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A usage record summary represents an aggregated view of how much usage was accrued for a
    /// subscription item within a subscription billing period.
    /// </summary>
    public class UsageRecordSummary : StripeEntity<UsageRecordSummary>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The invoice in which this usage period has been billed for.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        [JsonProperty("period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("period")]
#endif
        public UsageRecordSummaryPeriod Period { get; set; }

        /// <summary>
        /// The ID of the subscription item this summary is describing.
        /// </summary>
        [JsonProperty("subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_item")]
#endif
        public string SubscriptionItem { get; set; }

        /// <summary>
        /// The total usage within this usage period.
        /// </summary>
        [JsonProperty("total_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_usage")]
#endif
        public long TotalUsage { get; set; }
    }
}
