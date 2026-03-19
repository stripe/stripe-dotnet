// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2PaymentsSettlementAllocationIntentNotFoundEventData : StripeEntity<V2PaymentsSettlementAllocationIntentNotFoundEventData>
    {
        /// <summary>
        /// The ID of the ReceivedCredit.
        /// </summary>
        [JsonProperty("received_credit_id")]
        [STJS.JsonPropertyName("received_credit_id")]
        public string ReceivedCreditId { get; set; }
    }
}
