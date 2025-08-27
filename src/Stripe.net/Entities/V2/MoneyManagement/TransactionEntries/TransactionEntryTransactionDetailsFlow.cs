// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionEntryTransactionDetailsFlow : StripeEntity<TransactionEntryTransactionDetailsFlow>
    {
        /// <summary>
        /// Open Enum. Type of the flow that created the Transaction. The field matching this value
        /// will contain the ID of the flow.
        /// One of: <c>adjustment</c>, <c>currency_conversion</c>, <c>fee_transaction</c>,
        /// <c>inbound_transfer</c>, <c>outbound_payment</c>, <c>outbound_transfer</c>,
        /// <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// If applicable, the ID of the Adjustment that created this Transaction.
        /// </summary>
        [JsonProperty("adjustment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustment")]
#endif
        public string Adjustment { get; set; }

        /// <summary>
        /// In the future, this will be the ID of the currency conversion that created this
        /// Transaction. For now, this field is always null.
        /// </summary>
        [JsonProperty("currency_conversion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency_conversion")]
#endif
        public string CurrencyConversion { get; set; }

        /// <summary>
        /// If applicable, the ID of the FeeTransaction that created this Transaction.
        /// </summary>
        [JsonProperty("fee_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_transaction")]
#endif
        public string FeeTransaction { get; set; }

        /// <summary>
        /// If applicable, the ID of the InboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("inbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_transfer")]
#endif
        public string InboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundPayment that created this Transaction.
        /// </summary>
        [JsonProperty("outbound_payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payment")]
#endif
        public string OutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("outbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfer")]
#endif
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedCredit that created this Transaction.
        /// </summary>
        [JsonProperty("received_credit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit")]
#endif
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedDebit that created this Transaction.
        /// </summary>
        [JsonProperty("received_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debit")]
#endif
        public string ReceivedDebit { get; set; }
    }
}
