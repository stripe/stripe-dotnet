// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an invoice count dropped alert is firing.
    /// </summary>
    public class V2CoreHealthInvoiceCountDroppedFiringEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.invoice_count_dropped.firing event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthInvoiceCountDroppedFiringEventData Data { get; set; }
    }
}
