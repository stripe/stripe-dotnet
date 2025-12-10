// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Refund objects allow you to refund a previously created charge that isn't refunded yet.
    /// Funds are refunded to the credit or debit card that's initially charged.
    ///
    /// Related guide: <a href="https://docs.stripe.com/refunds">Refunds</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Refund : StripeEntity<Refund>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Amount, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// Balance transaction that describes the impact on your account balance.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge that's refunded.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. You can use this for displaying to users
        /// (available on non-card refunds only).
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        [JsonProperty("destination_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_details")]
#endif
        public RefundDestinationDetails DestinationDetails { get; set; }

        #region Expandable FailureBalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// After the refund fails, this balance transaction describes the adjustment made on your
        /// account balance that reverses the initial balance transaction.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction FailureBalanceTransaction
        {
            get => this.InternalFailureBalanceTransaction?.ExpandedObject;
            set => this.InternalFailureBalanceTransaction = SetExpandableFieldObject(value, this.InternalFailureBalanceTransaction);
        }

        [JsonProperty("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Provides the reason for the refund failure. Possible values are:
        /// <c>lost_or_stolen_card</c>, <c>expired_or_canceled_card</c>,
        /// <c>charge_for_pending_refund_disputed</c>, <c>insufficient_funds</c>, <c>declined</c>,
        /// <c>merchant_request</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_reason")]
#endif
        public string FailureReason { get; set; }

        /// <summary>
        /// For payment methods without native refund support (for example, Konbini, PromptPay),
        /// provide an email address for the customer to receive refund instructions.
        /// </summary>
        [JsonProperty("instructions_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("instructions_email")]
#endif
        public string InstructionsEmail { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_action")]
#endif
        public RefundNextAction NextAction { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent that's refunded.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// Provides the reason for why the refund is pending. Possible values are:
        /// <c>processing</c>, <c>insufficient_funds</c>, or <c>charge_pending</c>.
        /// One of: <c>charge_pending</c>, <c>insufficient_funds</c>, or <c>processing</c>.
        /// </summary>
        [JsonProperty("pending_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending_reason")]
#endif
        public string PendingReason { get; set; }

        [JsonProperty("presentment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("presentment_details")]
#endif
        public RefundPresentmentDetails PresentmentDetails { get; set; }

        /// <summary>
        /// Reason for the refund, which is either user-provided (<c>duplicate</c>,
        /// <c>fraudulent</c>, or <c>requested_by_customer</c>) or generated by Stripe internally
        /// (<c>expired_uncaptured_charge</c>).
        /// One of: <c>duplicate</c>, <c>expired_uncaptured_charge</c>, <c>fraudulent</c>, or
        /// <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// This is the transaction number that appears on email receipts sent for this refund.
        /// </summary>
        [JsonProperty("receipt_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_number")]
#endif
        public string ReceiptNumber { get; set; }

        #region Expandable SourceTransferReversal

        /// <summary>
        /// (ID of the TransferReversal)
        /// The transfer reversal that's associated with the refund. Only present if the charge came
        /// from another Stripe account.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public TransferReversal SourceTransferReversal
        {
            get => this.InternalSourceTransferReversal?.ExpandedObject;
            set => this.InternalSourceTransferReversal = SetExpandableFieldObject(value, this.InternalSourceTransferReversal);
        }

        [JsonProperty("source_transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_transfer_reversal")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TransferReversal>))]
#endif
        internal ExpandableField<TransferReversal> InternalSourceTransferReversal { get; set; }
        #endregion

        /// <summary>
        /// Status of the refund. This can be <c>pending</c>, <c>requires_action</c>,
        /// <c>succeeded</c>, <c>failed</c>, or <c>canceled</c>. Learn more about <a
        /// href="https://docs.stripe.com/refunds#failed-refunds">failed refunds</a>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        #region Expandable TransferReversal

        /// <summary>
        /// (ID of the TransferReversal)
        /// This refers to the transfer reversal object if the accompanying transfer reverses. This
        /// is only applicable if the charge was created using the destination parameter.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public TransferReversal TransferReversal
        {
            get => this.InternalTransferReversal?.ExpandedObject;
            set => this.InternalTransferReversal = SetExpandableFieldObject(value, this.InternalTransferReversal);
        }

        [JsonProperty("transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_reversal")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TransferReversal>))]
#endif
        internal ExpandableField<TransferReversal> InternalTransferReversal { get; set; }
        #endregion
    }
}
