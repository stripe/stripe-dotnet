// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an issuing authorization request timeout alert is firing.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.health.issuing_authorization_request_timeout.firing event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventData Data { get; set; }
    }
}
