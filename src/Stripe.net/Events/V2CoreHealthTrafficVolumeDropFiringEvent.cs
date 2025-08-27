// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a traffic volume drop alert is firing.
    /// </summary>
    public class V2CoreHealthTrafficVolumeDropFiringEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.health.traffic_volume_drop.firing event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthTrafficVolumeDropFiringEventData Data { get; set; }
    }
}
