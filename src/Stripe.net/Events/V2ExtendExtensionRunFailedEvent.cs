// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an extension run fails.
    /// </summary>
    public class V2ExtendExtensionRunFailedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.extend.extension_run.failed event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2ExtendExtensionRunFailedEventData Data { get; set; }
    }
}
