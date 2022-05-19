// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// You can reverse some <a
    /// href="https://stripe.com/docs/api#received_debits">ReceivedDebits</a> depending on their
    /// network and source flow. Reversing a ReceivedDebit leads to the creation of a new object
    /// known as a DebitReversal.
    /// </summary>
    public class DebitReversal : StripeEntity<DebitReversal>, IHasId, IHasMetadata, IHasObject
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
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The FinancialAccount to reverse funds from.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// A hosted transaction receipt URL that is provided when money movement is considered
        /// regulated under Stripe's money transmission licenses.
        /// </summary>
        [JsonProperty("hosted_regulatory_receipt_url")]
        public string HostedRegulatoryReceiptUrl { get; set; }

        /// <summary>
        /// Other flows linked to a DebitReversal.
        /// </summary>
        [JsonProperty("linked_flows")]
        public DebitReversalLinkedFlows LinkedFlows { get; set; }

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
        /// The rails used to reverse the funds.
        /// One of: <c>ach</c>, or <c>card</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// The ReceivedDebit being reversed.
        /// </summary>
        [JsonProperty("received_debit")]
        public string ReceivedDebit { get; set; }

        /// <summary>
        /// Status of the DebitReversal.
        /// One of: <c>failed</c>, <c>processing</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public DebitReversalStatusTransitions StatusTransitions { get; set; }

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
