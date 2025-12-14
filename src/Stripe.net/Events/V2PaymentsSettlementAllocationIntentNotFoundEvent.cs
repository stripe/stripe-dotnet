// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a ReceivedCredit has no SettlementAllocationIntent matching it.
    /// </summary>
    public class V2PaymentsSettlementAllocationIntentNotFoundEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.payments.settlement_allocation_intent.not_found event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2PaymentsSettlementAllocationIntentNotFoundEventData Data { get; set; }
    }
}
