// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
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
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// If applicable, the ID of the Adjustment linked to this Adjustment.
        /// </summary>
        [JsonProperty("adjustment")]
        [STJS.JsonPropertyName("adjustment")]
        public string Adjustment { get; set; }

        /// <summary>
        /// If applicable, the ID of the InboundTransfer linked to this Adjustment.
        /// </summary>
        [JsonProperty("inbound_transfer")]
        [STJS.JsonPropertyName("inbound_transfer")]
        public string InboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundPayment linked to this Adjustment.
        /// </summary>
        [JsonProperty("outbound_payment")]
        [STJS.JsonPropertyName("outbound_payment")]
        public string OutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundTransfer linked to this Adjustment.
        /// </summary>
        [JsonProperty("outbound_transfer")]
        [STJS.JsonPropertyName("outbound_transfer")]
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedCredit linked to this Adjustment.
        /// </summary>
        [JsonProperty("received_credit")]
        [STJS.JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedDebit linked to this Adjustment.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
