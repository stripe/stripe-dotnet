// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SettlementAllocationIntentSplitFlow : StripeEntity<SettlementAllocationIntentSplitFlow>
    {
        /// <summary>
        /// Type of the flow linked to the transaction which settled the
        /// SettlementAllocationIntentSplit. The field matching this value will contain the ID of
        /// the flow.
        /// One of: <c>outbound_payment</c>, <c>outbound_transfer</c>, or <c>received_credit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundPayment that created this transaction.
        /// </summary>
        [JsonProperty("outbound_payment")]
        [STJS.JsonPropertyName("outbound_payment")]
        public string OutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundTransfer that created this transaction.
        /// </summary>
        [JsonProperty("outbound_transfer")]
        [STJS.JsonPropertyName("outbound_transfer")]
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedCredit that created this transaction.
        /// </summary>
        [JsonProperty("received_credit")]
        [STJS.JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }
    }
}
