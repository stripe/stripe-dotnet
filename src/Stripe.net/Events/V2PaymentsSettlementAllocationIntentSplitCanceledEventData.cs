// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2PaymentsSettlementAllocationIntentSplitCanceledEventData : StripeEntity<V2PaymentsSettlementAllocationIntentSplitCanceledEventData>
    {
        /// <summary>
        /// The ID of the SettlementAllocationIntent this split belongs to.
        /// </summary>
        [JsonProperty("settlement_allocation_intent_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement_allocation_intent_id")]
#endif
        public string SettlementAllocationIntentId { get; set; }
    }
}
