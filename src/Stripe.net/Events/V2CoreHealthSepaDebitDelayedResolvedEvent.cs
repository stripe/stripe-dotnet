// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a SEPA debit delayed alert is resolved.
    /// </summary>
    public class V2CoreHealthSepaDebitDelayedResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.sepa_debit_delayed.resolved event.
        /// </summary>


        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2CoreHealthSepaDebitDelayedResolvedEventData Data { get; set; }


    }
}
