// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListDataMetrics : StripeEntity<SearchResultListDataMetrics>
    {
        /// <summary>
        /// Whether the metric query endpoint accepts a <c>currency</c> parameter for this metric.
        /// False for pure ratios and growth rates.
        /// </summary>
        [JsonProperty("accepts_currency")]
        [STJS.JsonPropertyName("accepts_currency")]
        public bool AcceptsCurrency { get; set; }

        /// <summary>
        /// Dimensions the metric can be filtered and grouped by.
        /// </summary>
        [JsonProperty("dimensions")]
        [STJS.JsonPropertyName("dimensions")]
        public List<SearchResultListDataMetricsDimension> Dimensions { get; set; }

        /// <summary>
        /// How the metric's value is formatted.
        /// One of: <c>currency</c>, <c>number</c>, or <c>percent</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("measure_format")]
        [STJS.JsonPropertyName("measure_format")]
        public string MeasureFormat { get; set; }

        /// <summary>
        /// The metric namespace. Metrics queried together in one metric query request must share a
        /// namespace.
        /// </summary>
        [JsonProperty("metric_namespace")]
        [STJS.JsonPropertyName("metric_namespace")]
        public string MetricNamespace { get; set; }
    }
}
