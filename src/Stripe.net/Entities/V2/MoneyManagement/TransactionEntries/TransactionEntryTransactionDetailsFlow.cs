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
        /// Open Enum. Type of the flow that created the Transaction. The field matching this value
        /// will contain the ID of the flow.
        /// One of: <c>adjustment</c>, <c>application_fee</c>, <c>application_fee_refund</c>,
        /// <c>charge</c>, <c>currency_conversion</c>, <c>dispute</c>, <c>fee_transaction</c>,
        /// <c>inbound_transfer</c>, <c>outbound_payment</c>, <c>outbound_transfer</c>,
        /// <c>payout</c>, <c>received_credit</c>, <c>received_debit</c>, <c>refund</c>,
        /// <c>reserve_hold</c>, <c>reserve_release</c>, <c>topup</c>, <c>transfer</c>,
        /// <c>transfer_reversal</c>, <c>treasury_credit_reversal</c>,
        /// <c>treasury_debit_reversal</c>, <c>treasury_inbound_transfer</c>,
        /// <c>treasury_issuing_authorization</c>, <c>treasury_other</c>,
        /// <c>treasury_outbound_payment</c>, <c>treasury_outbound_transfer</c>,
        /// <c>treasury_received_credit</c>, or <c>treasury_received_debit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// If applicable, the ID of the Adjustment that created this Transaction.
        /// </summary>
        [JsonProperty("adjustment")]
        [STJS.JsonPropertyName("adjustment")]
        public string Adjustment { get; set; }

        /// <summary>
        /// If applicable, the ID of the Application Fee that created this Transaction.
        /// </summary>
        [JsonProperty("application_fee")]
        [STJS.JsonPropertyName("application_fee")]
        public string ApplicationFee { get; set; }

        /// <summary>
        /// If applicable, the ID of the Application Fee Refund that created this Transaction.
        /// </summary>
        [JsonProperty("application_fee_refund")]
        [STJS.JsonPropertyName("application_fee_refund")]
        public string ApplicationFeeRefund { get; set; }

        /// <summary>
        /// If applicable, the ID of the Charge that created this Transaction.
        /// </summary>
        [JsonProperty("charge")]
        [STJS.JsonPropertyName("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// In the future, this will be the ID of the currency conversion that created this
        /// Transaction. For now, this field is always null.
        /// </summary>
        [JsonProperty("currency_conversion")]
        [STJS.JsonPropertyName("currency_conversion")]
        public string CurrencyConversion { get; set; }

        /// <summary>
        /// If applicable, the ID of the Dispute that created this Transaction.
        /// </summary>
        [JsonProperty("dispute")]
        [STJS.JsonPropertyName("dispute")]
        public string Dispute { get; set; }

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
        /// If applicable, the ID of the Payout that created this Transaction.
        /// </summary>
        [JsonProperty("payout")]
        [STJS.JsonPropertyName("payout")]
        public string Payout { get; set; }

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
        /// If applicable, the ID of the Refund that created this Transaction.
        /// </summary>
        [JsonProperty("refund")]
        [STJS.JsonPropertyName("refund")]
        public string Refund { get; set; }

        /// <summary>
        /// If applicable, the ID of the Reserve Hold that created this Transaction.
        /// </summary>
        [JsonProperty("reserve_hold")]
        [STJS.JsonPropertyName("reserve_hold")]
        public string ReserveHold { get; set; }

        /// <summary>
        /// If applicable, the ID of the Reserve Release that created this Transaction.
        /// </summary>
        [JsonProperty("reserve_release")]
        [STJS.JsonPropertyName("reserve_release")]
        public string ReserveRelease { get; set; }

        /// <summary>
        /// If applicable, the ID of the Topup that created this Transaction.
        /// </summary>
        [JsonProperty("topup")]
        [STJS.JsonPropertyName("topup")]
        public string Topup { get; set; }

        /// <summary>
        /// If applicable, the ID of the Transfer that created this Transaction.
        /// </summary>
        [JsonProperty("transfer")]
        [STJS.JsonPropertyName("transfer")]
        public string Transfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the Transfer Reversal that created this Transaction.
        /// </summary>
        [JsonProperty("transfer_reversal")]
        [STJS.JsonPropertyName("transfer_reversal")]
        public string TransferReversal { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury CreditReversal that created this Transaction.
        /// </summary>
        [JsonProperty("treasury_credit_reversal")]
        [STJS.JsonPropertyName("treasury_credit_reversal")]
        public string TreasuryCreditReversal { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury DebitReversal that created this Transaction.
        /// </summary>
        [JsonProperty("treasury_debit_reversal")]
        [STJS.JsonPropertyName("treasury_debit_reversal")]
        public string TreasuryDebitReversal { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury InboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("treasury_inbound_transfer")]
        [STJS.JsonPropertyName("treasury_inbound_transfer")]
        public string TreasuryInboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury IssuingAuthorization that created this
        /// Transaction.
        /// </summary>
        [JsonProperty("treasury_issuing_authorization")]
        [STJS.JsonPropertyName("treasury_issuing_authorization")]
        public string TreasuryIssuingAuthorization { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury OutboundPayment that created this Transaction.
        /// </summary>
        [JsonProperty("treasury_outbound_payment")]
        [STJS.JsonPropertyName("treasury_outbound_payment")]
        public string TreasuryOutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury OutboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("treasury_outbound_transfer")]
        [STJS.JsonPropertyName("treasury_outbound_transfer")]
        public string TreasuryOutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury ReceivedCredit that created this Transaction.
        /// </summary>
        [JsonProperty("treasury_received_credit")]
        [STJS.JsonPropertyName("treasury_received_credit")]
        public string TreasuryReceivedCredit { get; set; }

        /// <summary>
        /// If applicable, the ID of the Treasury ReceivedDebit that created this Transaction.
        /// </summary>
        [JsonProperty("treasury_received_debit")]
        [STJS.JsonPropertyName("treasury_received_debit")]
        public string TreasuryReceivedDebit { get; set; }
    }
}
