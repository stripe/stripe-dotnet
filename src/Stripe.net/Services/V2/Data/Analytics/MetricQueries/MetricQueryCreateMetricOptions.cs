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
        /// The Gen6 ID for this metric, e.g. metric_61Sud3n5oAGVCWiSr5.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The common name for this metric, e.g. mrr_minor_units.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
