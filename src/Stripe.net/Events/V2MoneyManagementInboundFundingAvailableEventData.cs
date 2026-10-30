// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementInboundFundingAvailableEventData : StripeEntity<V2MoneyManagementInboundFundingAvailableEventData>
    {
        /// <summary>
        /// The transaction ID of the inbound funding.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
