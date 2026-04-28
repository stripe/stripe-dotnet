// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Analytics
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MetricQueryResultDataResult : StripeEntity<MetricQueryResultDataResult>
    {
        /// <summary>
        /// If this is a monetary metric, the currency it is returned in. Otherwise null.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The Gen6 ID of this metric.
        /// </summary>
        [JsonProperty("metric")]
        [STJS.JsonPropertyName("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// The common name of this metric.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The numeric value of this metric.
        /// </summary>
        [JsonProperty("value")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
