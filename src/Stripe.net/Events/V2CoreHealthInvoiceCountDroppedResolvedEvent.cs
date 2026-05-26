// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an invoice count dropped alert is resolved.
    /// </summary>
    public class V2CoreHealthInvoiceCountDroppedResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.invoice_count_dropped.resolved event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthInvoiceCountDroppedResolvedEventData Data { get; set; }
    }
}
