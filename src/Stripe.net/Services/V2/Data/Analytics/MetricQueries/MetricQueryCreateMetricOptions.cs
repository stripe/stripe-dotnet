// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Analytics
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MetricQueryCreateMetricOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID for this metric (for example, <c>metric_61Sud3n5oAGVCWiSr5</c>). For the full
        /// list of supported metrics, see <a
        /// href="https://docs.stripe.com/data/analytics/supported-metrics">Supported metrics</a>.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The common name for this metric (for example, <c>revenue.mrr</c>). For the full list of
        /// supported metric names, see <a
        /// href="https://docs.stripe.com/data/analytics/supported-metrics">Supported metrics</a>.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
