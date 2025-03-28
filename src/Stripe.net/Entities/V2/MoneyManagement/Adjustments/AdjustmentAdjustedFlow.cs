// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AdjustmentAdjustedFlow : StripeEntity<AdjustmentAdjustedFlow>
    {
        /// <summary>
        /// Closed Enum. If applicable, the type of flow linked to this Adjustment. The field
        /// matching this value will contain the ID of the flow.
        /// One of: <c>adjustment</c>, <c>balance_exchange</c>, <c>inbound_payment</c>,
        /// <c>inbound_transfer</c>, <c>outbound_payment</c>, <c>outbound_transfer</c>,
        /// <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// If applicable, the ID of the Adjustment linked to this Adjustment.
        /// </summary>
        [JsonProperty("adjustment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustment")]
#endif
        public string Adjustment { get; set; }

        /// <summary>
        /// If applicable, the ID of the InboundTransfer linked to this Adjustment.
        /// </summary>
        [JsonProperty("inbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_transfer")]
#endif
        public string InboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundPayment linked to this Adjustment.
        /// </summary>
        [JsonProperty("outbound_payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payment")]
#endif
        public string OutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundTransfer linked to this Adjustment.
        /// </summary>
        [JsonProperty("outbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfer")]
#endif
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedCredit linked to this Adjustment.
        /// </summary>
        [JsonProperty("received_credit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit")]
#endif
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedDebit linked to this Adjustment.
        /// </summary>
        [JsonProperty("received_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debit")]
#endif
        public string ReceivedDebit { get; set; }
    }
}
