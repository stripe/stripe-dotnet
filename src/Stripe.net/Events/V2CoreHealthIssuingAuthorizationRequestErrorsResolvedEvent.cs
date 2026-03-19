// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an issuing authorization request errors alert is resolved.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.issuing_authorization_request_errors.resolved event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventData Data { get; set; }
    }
}
