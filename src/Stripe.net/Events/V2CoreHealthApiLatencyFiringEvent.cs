// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an API latency alert is firing.
    /// </summary>
    public class V2CoreHealthApiLatencyFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.api_latency.firing event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthApiLatencyFiringEventData Data { get; set; }
    }
}
