// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when an API latency alert is resolved.
    /// </summary>
    public class V2CoreHealthApiLatencyResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.api_latency.resolved event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthApiLatencyResolvedEventData Data { get; set; }


    }
}
