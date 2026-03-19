// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a ReceivedCredit has no SettlementAllocationIntent matching it.
    /// </summary>
    public class V2PaymentsSettlementAllocationIntentNotFoundEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.payments.settlement_allocation_intent.not_found event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2PaymentsSettlementAllocationIntentNotFoundEventData Data { get; set; }
    }
}
