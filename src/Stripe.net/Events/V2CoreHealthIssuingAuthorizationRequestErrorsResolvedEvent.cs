// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an issuing authorization request errors alert is resolved.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.health.issuing_authorization_request_errors.resolved event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventData Data { get; set; }
    }
}
