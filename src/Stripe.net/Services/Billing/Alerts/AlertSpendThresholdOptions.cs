// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertSpendThresholdOptions : INestedOptions
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
        public AlertSpendThresholdFiltersOptions Filters { get; set; }

        /// <summary>
        /// Defines the granularity of spend aggregation. Defaults to
        /// <c>pricing_plan_subscription</c>.
        /// </summary>
        [JsonProperty("group_by")]
        [STJS.JsonPropertyName("group_by")]
        public string GroupBy { get; set; }

        /// <summary>
        /// Defines at which value the alert will fire.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public AlertSpendThresholdGteOptions Gte { get; set; }
    }
}
