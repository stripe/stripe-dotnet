// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an event generation failure alert is resolved.
    /// </summary>
    public class V2CoreHealthEventGenerationFailureResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.event_generation_failure.resolved event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthEventGenerationFailureResolvedEventData Data { get; set; }
    }
}
