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
        /// The change to the available balance.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public V2.Amount Available { get; set; }

        /// <summary>
        /// The change to the <c>inbound_pending</c> balance.
        /// </summary>
        [JsonProperty("inbound_pending")]
        [STJS.JsonPropertyName("inbound_pending")]
        public V2.Amount InboundPending { get; set; }

        /// <summary>
        /// The change to the <c>outbound_pending</c> balance.
        /// </summary>
        [JsonProperty("outbound_pending")]
        [STJS.JsonPropertyName("outbound_pending")]
        public V2.Amount OutboundPending { get; set; }
    }
}
