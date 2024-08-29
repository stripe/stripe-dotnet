// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount (in cents) transferred.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the InboundTransfer is able to be canceled.
        /// </summary>
        [JsonProperty("cancelable")]
        public bool Cancelable { get; set; }

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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Details about this InboundTransfer's failure. Only set when status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failure_details")]
        public InboundTransferFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// The FinancialAccount that received the funds.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/treasury/moving-money/regulatory-receipts">hosted
        /// transaction receipt</a> URL that is provided when money movement is considered regulated
        /// under Stripe's money transmission licenses.
        /// </summary>
        [JsonProperty("hosted_regulatory_receipt_url")]
        public string HostedRegulatoryReceiptUrl { get; set; }

        [JsonProperty("linked_flows")]
        public InboundTransferLinkedFlows LinkedFlows { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The origin payment method to be debited for an InboundTransfer.
        /// </summary>
        [JsonProperty("origin_payment_method")]
        public string OriginPaymentMethod { get; set; }

        /// <summary>
        /// Details about the PaymentMethod for an InboundTransfer.
        /// </summary>
        [JsonProperty("origin_payment_method_details")]
        public InboundTransferOriginPaymentMethodDetails OriginPaymentMethodDetails { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the funds for an InboundTransfer were returned after the
        /// InboundTransfer went to the <c>succeeded</c> state.
        /// </summary>
        [JsonProperty("returned")]
        public bool? Returned { get; set; }

        /// <summary>
        /// Statement descriptor shown when funds are debited from the source. Not all payment
        /// networks support <c>statement_descriptor</c>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
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
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public InboundTransferStatusTransitions StatusTransitions { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The Transaction associated with this object.
        /// </summary>
        [JsonIgnore]
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
