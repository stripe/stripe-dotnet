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
        /// One of: <c>adjustment</c>, <c>application_fee</c>, <c>application_fee_refund</c>,
        /// <c>charge</c>, <c>currency_conversion</c>, <c>dispute</c>, <c>fee_transaction</c>,
        /// <c>inbound_transfer</c>, <c>outbound_payment</c>, <c>outbound_transfer</c>,
        /// <c>payout</c>, <c>received_credit</c>, <c>received_debit</c>, <c>refund</c>,
        /// <c>reserve_hold</c>, <c>reserve_release</c>, <c>topup</c>, <c>transfer</c>, or
        /// <c>transfer_reversal</c>.
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
        /// If applicable, the ID of the Application Fee that created this Transaction.
        /// </summary>
        [JsonProperty("application_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee")]
#endif
        public string ApplicationFee { get; set; }

        /// <summary>
        /// If applicable, the ID of the Application Fee Refund that created this Transaction.
        /// </summary>
        [JsonProperty("application_fee_refund")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_refund")]
#endif
        public string ApplicationFeeRefund { get; set; }

        /// <summary>
        /// If applicable, the ID of the Charge that created this Transaction.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }

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
        /// If applicable, the ID of the Dispute that created this Transaction.
        /// </summary>
        [JsonProperty("dispute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dispute")]
#endif
        public string Dispute { get; set; }

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
        /// If applicable, the ID of the Payout that created this Transaction.
        /// </summary>
        [JsonProperty("payout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout")]
#endif
        public string Payout { get; set; }

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

        /// <summary>
        /// If applicable, the ID of the Refund that created this Transaction.
        /// </summary>
        [JsonProperty("refund")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund")]
#endif
        public string Refund { get; set; }

        /// <summary>
        /// If applicable, the ID of the Reserve Hold that created this Transaction.
        /// </summary>
        [JsonProperty("reserve_hold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_hold")]
#endif
        public string ReserveHold { get; set; }

        /// <summary>
        /// If applicable, the ID of the Reserve Release that created this Transaction.
        /// </summary>
        [JsonProperty("reserve_release")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_release")]
#endif
        public string ReserveRelease { get; set; }

        /// <summary>
        /// If applicable, the ID of the Topup that created this Transaction.
        /// </summary>
        [JsonProperty("topup")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("topup")]
#endif
        public string Topup { get; set; }

        /// <summary>
        /// If applicable, the ID of the Transfer that created this Transaction.
        /// </summary>
        [JsonProperty("transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer")]
#endif
        public string Transfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the Transfer Reversal that created this Transaction.
        /// </summary>
        [JsonProperty("transfer_reversal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_reversal")]
#endif
        public string TransferReversal { get; set; }
    }
}
