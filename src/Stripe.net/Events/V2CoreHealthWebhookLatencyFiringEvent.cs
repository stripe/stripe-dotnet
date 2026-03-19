// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a webhook latency alert is firing.
    /// </summary>
    public class V2CoreHealthWebhookLatencyFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.webhook_latency.firing event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthWebhookLatencyFiringEventData Data { get; set; }
    }
}
