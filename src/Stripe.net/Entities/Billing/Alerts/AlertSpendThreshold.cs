// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertSpendThreshold : StripeEntity<AlertSpendThreshold>
    {
        /// <summary>
        /// Defines the period over which spend is aggregated.
        /// </summary>
        [JsonProperty("aggregation_period")]
        [STJS.JsonPropertyName("aggregation_period")]
        public string AggregationPeriod { get; set; }

        /// <summary>
        /// Filters to scope the spend calculation.
        /// </summary>
        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public AlertSpendThresholdFilters Filters { get; set; }

        /// <summary>
        /// Defines the granularity of spend aggregation.
        /// </summary>
        [JsonProperty("group_by")]
        [STJS.JsonPropertyName("group_by")]
        public string GroupBy { get; set; }

        /// <summary>
        /// The threshold value configuration for a spend threshold alert.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public AlertSpendThresholdGte Gte { get; set; }
    }
}
