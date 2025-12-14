// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2PaymentsSettlementAllocationIntentNotFoundEventData : StripeEntity<V2PaymentsSettlementAllocationIntentNotFoundEventData>
    {
        /// <summary>
        /// The ID of the ReceivedCredit.
        /// </summary>
        [JsonProperty("received_credit_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit_id")]
#endif
        public string ReceivedCreditId { get; set; }
    }
}
