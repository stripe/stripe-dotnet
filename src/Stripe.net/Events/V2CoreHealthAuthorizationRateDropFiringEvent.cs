// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when an authorization rate drop alert is firing.
    /// </summary>
    public class V2CoreHealthAuthorizationRateDropFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.authorization_rate_drop.firing event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthAuthorizationRateDropFiringEventData Data { get; set; }


    }
}
