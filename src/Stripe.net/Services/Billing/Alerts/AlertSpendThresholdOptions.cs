// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertSpendThresholdOptions : INestedOptions
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
        public AlertSpendThresholdFiltersOptions Filters { get; set; }

        /// <summary>
        /// Defines the granularity of spend aggregation. Defaults to
        /// <c>pricing_plan_subscription</c>.
        /// </summary>
        [JsonProperty("group_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("group_by")]
#endif
        public string GroupBy { get; set; }

        /// <summary>
        /// Defines at which value the alert will fire.
        /// </summary>
        [JsonProperty("gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gte")]
#endif
        public AlertSpendThresholdGteOptions Gte { get; set; }
    }
}
