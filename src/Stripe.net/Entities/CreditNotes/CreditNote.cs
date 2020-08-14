namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditNote : StripeEntity<CreditNote>, IHasId, IHasMetadata, IHasObject
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
        /// The integer amount in <strong>%s</strong> representing the total amount of the credit
        /// note, including tax.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

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

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the customer.
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

        #region Expandable CustomerBalanceTransaction

        /// <summary>
        /// (ID of the CustomerBalanceTransaction)
        /// Customer balance transaction related to this credit note.
        /// </summary>
        [JsonIgnore]
        public string CustomerBalanceTransactionId
        {
            get => this.InternalCustomerBalanceTransaction?.Id;
            set => this.InternalCustomerBalanceTransaction = SetExpandableFieldId(value, this.InternalCustomerBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Customer balance transaction related to this credit note.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public CustomerBalanceTransaction CustomerBalanceTransaction
        {
            get => this.InternalCustomerBalanceTransaction?.ExpandedObject;
            set => this.InternalCustomerBalanceTransaction = SetExpandableFieldObject(value, this.InternalCustomerBalanceTransaction);
        }

        [JsonProperty("customer_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<CustomerBalanceTransaction>))]
        internal ExpandableField<CustomerBalanceTransaction> InternalCustomerBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// The integer amount in <strong>%s</strong> representing the total amount of discount that
        /// was credited.
        /// </summary>
        [JsonProperty("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per discount for all line items.
        /// </summary>
        [JsonProperty("discount_amounts")]
        public List<CreditNoteDiscountAmount> DiscountAmounts { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the invoice.
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
        /// Line items that make up the credit note.
        /// </summary>
        [JsonProperty("lines")]
        public StripeList<CreditNoteLineItem> Lines { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Customer-facing text that appears on the credit note PDF.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A unique number that identifies this particular credit note and appears on the PDF of
        /// the credit note and its associated invoice.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Amount that was credited outside of Stripe.
        /// </summary>
        [JsonProperty("out_of_band_amount")]
        public long? OutOfBandAmount { get; set; }

        /// <summary>
        /// The link to download the PDF of the credit note.
        /// </summary>
        [JsonProperty("pdf")]
        public string Pdf { get; set; }

        /// <summary>
        /// Reason for issuing this credit note, one of <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>order_change</c>, or <c>product_unsatisfactory</c>.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, <c>order_change</c>, or
        /// <c>product_unsatisfactory</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        #region Expandable Refund

        /// <summary>
        /// (ID of the Refund)
        /// Refund related to this credit note.
        /// </summary>
        [JsonIgnore]
        public string RefundId
        {
            get => this.InternalRefund?.Id;
            set => this.InternalRefund = SetExpandableFieldId(value, this.InternalRefund);
        }

        /// <summary>
        /// (Expanded)
        /// Refund related to this credit note.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Refund Refund
        {
            get => this.InternalRefund?.ExpandedObject;
            set => this.InternalRefund = SetExpandableFieldObject(value, this.InternalRefund);
        }

        [JsonProperty("refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalRefund { get; set; }
        #endregion

        /// <summary>
        /// Status of this credit note, one of <c>issued</c> or <c>void</c>. Learn more about <a
        /// href="https://stripe.com/docs/billing/invoices/credit-notes#voiding">voiding credit
        /// notes</a>.
        /// One of: <c>issued</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The integer amount in <strong>%s</strong> representing the amount of the credit note,
        /// excluding tax and invoice level discounts.
        /// </summary>
        [JsonProperty("subtotal")]
        public long Subtotal { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per tax rate for all line items.
        /// </summary>
        [JsonProperty("tax_amounts")]
        public List<CreditNoteTaxAmount> TaxAmounts { get; set; }

        /// <summary>
        /// The integer amount in <strong>%s</strong> representing the total amount of the credit
        /// note, including tax and all discount.
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }

        /// <summary>
        /// Type of this credit note, one of <c>pre_payment</c> or <c>post_payment</c>. A
        /// <c>pre_payment</c> credit note means it was issued when the invoice was open. A
        /// <c>post_payment</c> credit note means it was issued when the invoice was paid.
        /// One of: <c>post_payment</c>, or <c>pre_payment</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The time that the credit note was voided.
        /// </summary>
        [JsonProperty("voided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
