// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a meter event summaries delayed alert is firing.
    /// </summary>
    public class V2CoreHealthMeterEventSummariesDelayedFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.meter_event_summaries_delayed.firing event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthMeterEventSummariesDelayedFiringEventData Data { get; set; }
    }
}
