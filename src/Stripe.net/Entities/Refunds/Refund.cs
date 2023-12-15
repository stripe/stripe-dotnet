// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Refund objects allow you to refund a previously created charge that isn't refunded yet.
    /// Funds are refunded to the credit or debit card that's initially charged.
    ///
    /// Related guide: <a href="https://stripe.com/docs/refunds">Refunds</a>.
    /// </summary>
    public class Refund : StripeEntity<Refund>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// Balance transaction that describes the impact on your account balance.
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Balance transaction that describes the impact on your account balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge that's refunded.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the charge that's refunded.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. You can use this for displaying to users
        /// (available on non-card refunds only).
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("destination_details")]
        public RefundDestinationDetails DestinationDetails { get; set; }

        #region Expandable FailureBalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// After the refund fails, this balance transaction describes the adjustment made on your
        /// account balance that reverses the initial balance transaction.
        /// </summary>
        [JsonIgnore]
        public string FailureBalanceTransactionId
        {
            get => this.InternalFailureBalanceTransaction?.Id;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldId(value, this.InternalFailureBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// After the refund fails, this balance transaction describes the adjustment made on your
        /// account balance that reverses the initial balance transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction
        {
            get => this.InternalFailureBalanceTransaction?.ExpandedObject;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldObject(value, this.InternalFailureBalanceTransaction);
        }

        [JsonProperty("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Provides the reason for the refund failure. Possible values are:
        /// <c>lost_or_stolen_card</c>, <c>expired_or_canceled_card</c>,
        /// <c>charge_for_pending_refund_disputed</c>, <c>insufficient_funds</c>, <c>declined</c>,
        /// <c>merchant_request</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// For payment methods without native refund support (for example, Konbini, PromptPay),
        /// provide an email address for the customer to receive refund instructions.
        /// </summary>
        [JsonProperty("instructions_email")]
        public string InstructionsEmail { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_action")]
        public RefundNextAction NextAction { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent that's refunded.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentIntent that's refunded.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// Reason for the refund, which is either user-provided (<c>duplicate</c>,
        /// <c>fraudulent</c>, or <c>requested_by_customer</c>) or generated by Stripe internally
        /// (<c>expired_uncaptured_charge</c>).
        /// One of: <c>duplicate</c>, <c>expired_uncaptured_charge</c>, <c>fraudulent</c>, or
        /// <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this refund.
        /// </summary>
        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        #region Expandable SourceTransferReversal

        /// <summary>
        /// (ID of the TransferReversal)
        /// The transfer reversal that's associated with the refund. Only present if the charge came
        /// from another Stripe account.
        /// </summary>
        [JsonIgnore]
        public string SourceTransferReversalId
        {
            get => this.InternalSourceTransferReversal?.Id;
            set => this.InternalSourceTransferReversal = SetExpandableFieldId(value, this.InternalSourceTransferReversal);
        }

        /// <summary>
        /// (Expanded)
        /// The transfer reversal that's associated with the refund. Only present if the charge came
        /// from another Stripe account.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public TransferReversal SourceTransferReversal
        {
            get => this.InternalSourceTransferReversal?.ExpandedObject;
            set => this.InternalSourceTransferReversal = SetExpandableFieldObject(value, this.InternalSourceTransferReversal);
        }

        [JsonProperty("source_transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
        internal ExpandableField<TransferReversal> InternalSourceTransferReversal { get; set; }
        #endregion

        /// <summary>
        /// Status of the refund. This can be <c>pending</c>, <c>requires_action</c>,
        /// <c>succeeded</c>, <c>failed</c>, or <c>canceled</c>. Learn more about <a
        /// href="https://stripe.com/docs/refunds#failed-refunds">failed refunds</a>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable TransferReversal

        /// <summary>
        /// (ID of the TransferReversal)
        /// This refers to the transfer reversal object if the accompanying transfer reverses. This
        /// is only applicable if the charge was created using the destination parameter.
        /// </summary>
        [JsonIgnore]
        public string TransferReversalId
        {
            get => this.InternalTransferReversal?.Id;
            set => this.InternalTransferReversal = SetExpandableFieldId(value, this.InternalTransferReversal);
        }

        /// <summary>
        /// (Expanded)
        /// This refers to the transfer reversal object if the accompanying transfer reverses. This
        /// is only applicable if the charge was created using the destination parameter.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public TransferReversal TransferReversal
        {
            get => this.InternalTransferReversal?.ExpandedObject;
            set => this.InternalTransferReversal = SetExpandableFieldObject(value, this.InternalTransferReversal);
        }

        [JsonProperty("transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
        internal ExpandableField<TransferReversal> InternalTransferReversal { get; set; }
        #endregion
    }
}
