// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a payment method error alert is resolved.
    /// </summary>
    public class V2CoreHealthPaymentMethodErrorResolvedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.health.payment_method_error.resolved event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthPaymentMethodErrorResolvedEventData Data { get; set; }
    }
}
