// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a SEPA debit delayed alert is resolved.
    /// </summary>
    public class V2CoreHealthSepaDebitDelayedResolvedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.core.health.sepa_debit_delayed.resolved event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreHealthSepaDebitDelayedResolvedEventData Data { get; set; }
    }
}
