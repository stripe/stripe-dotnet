// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when an issuing authorization request errors alert is firing.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.issuing_authorization_request_errors.firing event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventData Data { get; set; }


    }
}
