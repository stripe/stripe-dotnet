namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerBalanceTransaction : StripeEntity<CustomerBalanceTransaction>, IHasId, IHasMetadata, IHasObject
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
        /// The amount of the transaction. A negative value is a credit for the customer's balance,
        /// and a positive value is a debit to the customer's <c>balance</c>.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable CreditNote

        /// <summary>
        /// (ID of the CreditNote)
        /// The ID of the credit note (if any) related to the transaction.
        /// </summary>
        [JsonIgnore]
        public string CreditNoteId
        {
            get => this.InternalCreditNote?.Id;
            set => this.InternalCreditNote = SetExpandableFieldId(value, this.InternalCreditNote);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the credit note (if any) related to the transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public CreditNote CreditNote
        {
            get => this.InternalCreditNote?.ExpandedObject;
            set => this.InternalCreditNote = SetExpandableFieldObject(value, this.InternalCreditNote);
        }

        [JsonProperty("credit_note")]
        [JsonConverter(typeof(ExpandableFieldConverter<CreditNote>))]
        internal ExpandableField<CreditNote> InternalCreditNote { get; set; }
        #endregion

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer the transaction belongs to.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer the transaction belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The customer's <c>balance</c> after the transaction was applied. A negative value
        /// decreases the amount due on the customer's next invoice. A positive value increases the
        /// amount due on the customer's next invoice.
        /// </summary>
        [JsonProperty("ending_balance")]
        public long EndingBalance { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The ID of the invoice (if any) related to the transaction.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the invoice (if any) related to the transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

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
        /// Transaction type: <c>adjustment</c>, <c>applied_to_invoice</c>, <c>credit_note</c>,
        /// <c>initial</c>, <c>invoice_too_large</c>, <c>invoice_too_small</c>,
        /// <c>unspent_receiver_credit</c>, or <c>unapplied_from_invoice</c>. See the <a
        /// href="https://stripe.com/docs/billing/customer/balance#types">Customer Balance page</a>
        /// to learn more about transaction types.
        /// One of: <c>adjustment</c>, <c>applied_to_invoice</c>, <c>credit_note</c>,
        /// <c>initial</c>, <c>invoice_too_large</c>, <c>invoice_too_small</c>, <c>migration</c>,
        /// <c>unapplied_from_invoice</c>, or <c>unspent_receiver_credit</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
