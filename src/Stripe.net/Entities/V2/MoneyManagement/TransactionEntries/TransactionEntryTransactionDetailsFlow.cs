// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEntryTransactionDetailsFlow : StripeEntity<TransactionEntryTransactionDetailsFlow>
    {
        /// <summary>
        /// If applicable, the ID of the Adjustment that created this Transaction.
        /// </summary>
        [JsonProperty("adjustment")]
        [STJS.JsonPropertyName("adjustment")]
        public string Adjustment { get; set; }

        /// <summary>
        /// In the future, this will be the ID of the currency conversion that created this
        /// Transaction. For now, this field is always null.
        /// </summary>
        [JsonProperty("currency_conversion")]
        [STJS.JsonPropertyName("currency_conversion")]
        public string CurrencyConversion { get; set; }

        /// <summary>
        /// If applicable, the ID of the FeeTransaction that created this Transaction.
        /// </summary>
        [JsonProperty("fee_transaction")]
        [STJS.JsonPropertyName("fee_transaction")]
        public string FeeTransaction { get; set; }

        /// <summary>
        /// If applicable, the ID of the InboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("inbound_transfer")]
        [STJS.JsonPropertyName("inbound_transfer")]
        public string InboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundPayment that created this Transaction.
        /// </summary>
        [JsonProperty("outbound_payment")]
        [STJS.JsonPropertyName("outbound_payment")]
        public string OutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("outbound_transfer")]
        [STJS.JsonPropertyName("outbound_transfer")]
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedCredit that created this Transaction.
        /// </summary>
        [JsonProperty("received_credit")]
        [STJS.JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedDebit that created this Transaction.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }

        /// <summary>
        /// Open Enum. Type of the flow that created the Transaction. The field matching this value
        /// will contain the ID of the flow.
        /// One of: <c>adjustment</c>, <c>currency_conversion</c>, <c>fee_transaction</c>,
        /// <c>inbound_transfer</c>, <c>outbound_payment</c>, <c>outbound_transfer</c>,
        /// <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
