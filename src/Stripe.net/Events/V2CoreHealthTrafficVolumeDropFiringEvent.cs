// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a traffic volume drop alert is firing.
    /// </summary>
    public class V2CoreHealthTrafficVolumeDropFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.traffic_volume_drop.firing event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthTrafficVolumeDropFiringEventData Data { get; set; }
    }
}
