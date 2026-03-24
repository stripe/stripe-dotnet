// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEntryBalanceImpact : StripeEntity<TransactionEntryBalanceImpact>
    {
        /// <summary>
        /// Impact to the available balance.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public V2.Amount Available { get; set; }

        /// <summary>
        /// Impact to the inbound_pending balance.
        /// </summary>
        [JsonProperty("inbound_pending")]
        [STJS.JsonPropertyName("inbound_pending")]
        public V2.Amount InboundPending { get; set; }

        /// <summary>
        /// Impact to the outbound_pending balance.
        /// </summary>
        [JsonProperty("outbound_pending")]
        [STJS.JsonPropertyName("outbound_pending")]
        public V2.Amount OutboundPending { get; set; }
    }
}
