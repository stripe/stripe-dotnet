// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertSpendThreshold : StripeEntity<AlertSpendThreshold>
    {
        /// <summary>
        /// Defines the period over which spend is aggregated.
        /// </summary>
        [JsonProperty("aggregation_period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aggregation_period")]
#endif
        public string AggregationPeriod { get; set; }

        /// <summary>
        /// Filters to scope the spend calculation.
        /// </summary>
        [JsonProperty("filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filters")]
#endif
        public AlertSpendThresholdFilters Filters { get; set; }

        /// <summary>
        /// Defines the granularity of spend aggregation.
        /// </summary>
        [JsonProperty("group_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("group_by")]
#endif
        public string GroupBy { get; set; }

        /// <summary>
        /// The threshold value configuration for a spend threshold alert.
        /// </summary>
        [JsonProperty("gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gte")]
#endif
        public AlertSpendThresholdGte Gte { get; set; }
    }
}
