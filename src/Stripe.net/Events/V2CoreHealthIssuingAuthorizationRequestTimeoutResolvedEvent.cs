// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when an issuing authorization request timeout alert is resolved.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.issuing_authorization_request_timeout.resolved event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventData Data { get; set; }


    }
}
