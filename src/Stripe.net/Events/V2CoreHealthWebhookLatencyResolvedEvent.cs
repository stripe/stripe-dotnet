// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a webhook latency alert is resolved.
    /// </summary>
    public class V2CoreHealthWebhookLatencyResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.webhook_latency.resolved event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthWebhookLatencyResolvedEventData Data { get; set; }


    }
}
