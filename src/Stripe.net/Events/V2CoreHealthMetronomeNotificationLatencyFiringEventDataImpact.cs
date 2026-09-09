// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthMetronomeNotificationLatencyFiringEventDataImpact : StripeEntity<V2CoreHealthMetronomeNotificationLatencyFiringEventDataImpact>
    {
        /// <summary>
        /// The impacted Metronome billing pipeline.
        /// One of: <c>configuration_triggered</c>, <c>high_cardinality_usage_triggered</c>,
        /// <c>standard_usage_triggered</c>, or <c>time_triggered</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("pipeline")]
        [STJS.JsonPropertyName("pipeline")]
        public string Pipeline { get; set; }
    }
}
