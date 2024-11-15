// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Use <a
    /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/into/inbound-transfers">InboundTransfers</a>
    /// to add funds to your <a
    /// href="https://stripe.com/docs/api#financial_accounts">FinancialAccount</a> via a
    /// PaymentMethod that is owned by you. The funds will be transferred via an ACH debit.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/into/inbound-transfers">Moving
    /// money with Treasury using InboundTransfer objects</a>.
    /// </summary>
    public class InboundTransfer : StripeEntity<InboundTransfer>, IHasId, IHasMetadata, IHasObject
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
        /// Amount (in cents) transferred.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long Amount { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the InboundTransfer is able to be canceled.
        /// </summary>
        [JsonProperty("cancelable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancelable")]
#endif

        public bool Cancelable { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// Details about this InboundTransfer's failure. Only set when status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failure_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_details")]
#endif

        public InboundTransferFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// The FinancialAccount that received the funds.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif

        public string FinancialAccount { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/treasury/moving-money/regulatory-receipts">hosted
        /// transaction receipt</a> URL that is provided when money movement is considered regulated
        /// under Stripe's money transmission licenses.
        /// </summary>
        [JsonProperty("hosted_regulatory_receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_regulatory_receipt_url")]
#endif

        public string HostedRegulatoryReceiptUrl { get; set; }

        [JsonProperty("linked_flows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("linked_flows")]
#endif

        public InboundTransferLinkedFlows LinkedFlows { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The origin payment method to be debited for an InboundTransfer.
        /// </summary>
        [JsonProperty("origin_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("origin_payment_method")]
#endif

        public string OriginPaymentMethod { get; set; }

        /// <summary>
        /// Details about the PaymentMethod for an InboundTransfer.
        /// </summary>
        [JsonProperty("origin_payment_method_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("origin_payment_method_details")]
#endif

        public InboundTransferOriginPaymentMethodDetails OriginPaymentMethodDetails { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the funds for an InboundTransfer were returned after the
        /// InboundTransfer went to the <c>succeeded</c> state.
        /// </summary>
        [JsonProperty("returned")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned")]
#endif

        public bool? Returned { get; set; }

        /// <summary>
        /// Statement descriptor shown when funds are debited from the source. Not all payment
        /// networks support <c>statement_descriptor</c>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif

        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Status of the InboundTransfer: <c>processing</c>, <c>succeeded</c>, <c>failed</c>, and
        /// <c>canceled</c>. An InboundTransfer is <c>processing</c> if it is created and pending.
        /// The status changes to <c>succeeded</c> once the funds have been "confirmed" and a
        /// <c>transaction</c> is created and posted. The status changes to <c>failed</c> if the
        /// transfer fails.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>processing</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif

        public InboundTransferStatusTransitions StatusTransitions { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The Transaction associated with this object.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string TransactionId
        {
            get => this.InternalTransaction?.Id;
            set => this.InternalTransaction = SetExpandableFieldId(value, this.InternalTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The Transaction associated with this object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Transaction Transaction
        {
            get => this.InternalTransaction?.ExpandedObject;
            set => this.InternalTransaction = SetExpandableFieldObject(value, this.InternalTransaction);
        }

        [JsonProperty("transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
        internal ExpandableField<Transaction> InternalTransaction { get; set; }
        #endregion
    }
}
