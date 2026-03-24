// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a payment method error alert is firing.
    /// </summary>
    public class V2CoreHealthPaymentMethodErrorFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.payment_method_error.firing event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthPaymentMethodErrorFiringEventData Data { get; set; }


    }
}
