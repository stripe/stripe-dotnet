// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Metronome notification latency alert is firing.
    /// </summary>
    public class V2CoreHealthMetronomeNotificationLatencyFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.metronome_notification_latency.firing event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthMetronomeNotificationLatencyFiringEventData Data { get; set; }
    }
}
