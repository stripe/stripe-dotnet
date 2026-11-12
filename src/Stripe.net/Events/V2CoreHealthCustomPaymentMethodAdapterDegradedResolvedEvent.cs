// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a custom payment method adapter degraded alert is resolved.
    /// </summary>
    public class V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.custom_payment_method_adapter_degraded.resolved event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEventData Data { get; set; }
    }
}
