// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a traffic volume drop alert is resolved.
    /// </summary>
    public class V2CoreHealthTrafficVolumeDropResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.traffic_volume_drop.resolved event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthTrafficVolumeDropResolvedEventData Data { get; set; }


    }
}
