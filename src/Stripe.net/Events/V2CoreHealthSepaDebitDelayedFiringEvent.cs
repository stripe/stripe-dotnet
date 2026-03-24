// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a SEPA debit delayed alert is firing.
    /// </summary>
    public class V2CoreHealthSepaDebitDelayedFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.sepa_debit_delayed.firing event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthSepaDebitDelayedFiringEventData Data { get; set; }
    }
}
