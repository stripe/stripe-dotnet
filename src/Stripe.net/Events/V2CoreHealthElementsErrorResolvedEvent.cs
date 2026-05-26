// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an elements error alert is resolved.
    /// </summary>
    public class V2CoreHealthElementsErrorResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.elements_error.resolved event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthElementsErrorResolvedEventData Data { get; set; }
    }
}
