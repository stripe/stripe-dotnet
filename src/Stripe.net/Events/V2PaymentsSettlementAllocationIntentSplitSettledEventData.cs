// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2PaymentsSettlementAllocationIntentSplitSettledEventData : StripeEntity<V2PaymentsSettlementAllocationIntentSplitSettledEventData>
    {
        /// <summary>
        /// The ID of the SettlementAllocationIntent this split belongs to.
        /// </summary>
        [JsonProperty("settlement_allocation_intent_id")]
        [STJS.JsonPropertyName("settlement_allocation_intent_id")]
        public string SettlementAllocationIntentId { get; set; }
    }
}
