// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettlementAllocationIntentSplitFlow : StripeEntity<SettlementAllocationIntentSplitFlow>
    {
        /// <summary>
        /// Type of the flow linked to the transaction which settled the
        /// SettlementAllocationIntentSplit. The field matching this value will contain the ID of
        /// the flow.
        /// One of: <c>outbound_payment</c>, <c>outbound_transfer</c>, or <c>received_credit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundPayment that created this transaction.
        /// </summary>
        [JsonProperty("outbound_payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payment")]
#endif
        public string OutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundTransfer that created this transaction.
        /// </summary>
        [JsonProperty("outbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfer")]
#endif
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedCredit that created this transaction.
        /// </summary>
        [JsonProperty("received_credit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit")]
#endif
        public string ReceivedCredit { get; set; }
    }
}
