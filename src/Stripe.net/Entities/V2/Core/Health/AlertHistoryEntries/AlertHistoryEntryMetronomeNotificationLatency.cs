// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertHistoryEntryMetronomeNotificationLatency : StripeEntity<AlertHistoryEntryMetronomeNotificationLatency>
    {
        /// <summary>
        /// The impacted Metronome billing pipeline.
        /// One of: <c>configuration_triggered</c>, <c>high_cardinality_usage_triggered</c>,
        /// <c>standard_usage_triggered</c>, or <c>time_triggered</c>.
        /// </summary>
        [JsonProperty("pipeline")]
        [STJS.JsonPropertyName("pipeline")]
        public string Pipeline { get; set; }
    }
}
