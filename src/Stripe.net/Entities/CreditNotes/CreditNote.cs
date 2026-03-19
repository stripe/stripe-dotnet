// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Issue a credit note to adjust an invoice's amount after the invoice is finalized.
    ///
    /// Related guide: <a href="https://docs.stripe.com/billing/invoices/credit-notes">Credit
    /// notes</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditNote : StripeEntity<CreditNote>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// credit note, including tax.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
        [STJS.JsonPropertyName("amount_shipping")]
        public long AmountShipping { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// ID of the account representing the customer.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        #region Expandable CustomerBalanceTransaction

        /// <summary>
        /// (ID of the CustomerBalanceTransaction)
        /// Customer balance transaction related to this credit note.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public CustomerBalanceTransaction CustomerBalanceTransaction
        {
            get => this.InternalCustomerBalanceTransaction?.ExpandedObject;
            set => this.InternalCustomerBalanceTransaction = SetExpandableFieldObject(value, this.InternalCustomerBalanceTransaction);
        }

        [JsonProperty("customer_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<CustomerBalanceTransaction>))]
        [STJS.JsonPropertyName("customer_balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<CustomerBalanceTransaction>))]
        internal ExpandableField<CustomerBalanceTransaction> InternalCustomerBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of
        /// discount that was credited.
        /// </summary>
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per discount for all line items.
        /// </summary>
        [JsonProperty("discount_amounts")]
        [STJS.JsonPropertyName("discount_amounts")]
        public List<CreditNoteDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// The date when this credit note is in effect. Same as <c>created</c> unless overwritten.
        /// When defined, this value replaces the system-generated 'Date of issue' printed on the
        /// credit note PDF.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EffectiveAt { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        [STJS.JsonPropertyName("invoice")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Line items that make up the credit note.
        /// </summary>
        [JsonProperty("lines")]
        [STJS.JsonPropertyName("lines")]
        public StripeList<CreditNoteLineItem> Lines { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Customer-facing text that appears on the credit note PDF.
        /// </summary>
        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A unique number that identifies this particular credit note and appears on the PDF of
        /// the credit note and its associated invoice.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Amount that was credited outside of Stripe.
        /// </summary>
        [JsonProperty("out_of_band_amount")]
        [STJS.JsonPropertyName("out_of_band_amount")]
        public long? OutOfBandAmount { get; set; }

        /// <summary>
        /// The link to download the PDF of the credit note.
        /// </summary>
        [JsonProperty("pdf")]
        [STJS.JsonPropertyName("pdf")]
        public string Pdf { get; set; }

        /// <summary>
        /// The amount of the credit note that was refunded to the customer, credited to the
        /// customer's balance, credited outside of Stripe, or any combination thereof.
        /// </summary>
        [JsonProperty("post_payment_amount")]
        [STJS.JsonPropertyName("post_payment_amount")]
        public long PostPaymentAmount { get; set; }

        /// <summary>
        /// The amount of the credit note by which the invoice's <c>amount_remaining</c> and
        /// <c>amount_due</c> were reduced.
        /// </summary>
        [JsonProperty("pre_payment_amount")]
        [STJS.JsonPropertyName("pre_payment_amount")]
        public long PrePaymentAmount { get; set; }

        /// <summary>
        /// The pretax credit amounts (ex: discount, credit grants, etc) for all line items.
        /// </summary>
        [JsonProperty("pretax_credit_amounts")]
        [STJS.JsonPropertyName("pretax_credit_amounts")]
        public List<CreditNotePretaxCreditAmount> PretaxCreditAmounts { get; set; }

        /// <summary>
        /// Reason for issuing this credit note, one of <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>order_change</c>, or <c>product_unsatisfactory</c>.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, <c>order_change</c>, or
        /// <c>product_unsatisfactory</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Refunds related to this credit note.
        /// </summary>
        [JsonProperty("refunds")]
        [STJS.JsonPropertyName("refunds")]
        public List<CreditNoteRefund> Refunds { get; set; }

        /// <summary>
        /// The details of the cost of shipping, including the ShippingRate applied to the invoice.
        /// </summary>
        [JsonProperty("shipping_cost")]
        [STJS.JsonPropertyName("shipping_cost")]
        public CreditNoteShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Status of this credit note, one of <c>issued</c> or <c>void</c>. Learn more about <a
        /// href="https://docs.stripe.com/billing/invoices/credit-notes#voiding">voiding credit
        /// notes</a>.
        /// One of: <c>issued</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the amount of the credit
        /// note, excluding exclusive tax and invoice level discounts.
        /// </summary>
        [JsonProperty("subtotal")]
        [STJS.JsonPropertyName("subtotal")]
        public long Subtotal { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the amount of the credit
        /// note, excluding all tax and invoice level discounts.
        /// </summary>
        [JsonProperty("subtotal_excluding_tax")]
        [STJS.JsonPropertyName("subtotal_excluding_tax")]
        public long? SubtotalExcludingTax { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// credit note, including tax and all discount.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public long Total { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// credit note, excluding tax, but including discounts.
        /// </summary>
        [JsonProperty("total_excluding_tax")]
        [STJS.JsonPropertyName("total_excluding_tax")]
        public long? TotalExcludingTax { get; set; }

        /// <summary>
        /// The aggregate tax information for all line items.
        /// </summary>
        [JsonProperty("total_taxes")]
        [STJS.JsonPropertyName("total_taxes")]
        public List<CreditNoteTotalTax> TotalTaxes { get; set; }

        /// <summary>
        /// Type of this credit note, one of <c>pre_payment</c> or <c>post_payment</c>. A
        /// <c>pre_payment</c> credit note means it was issued when the invoice was open. A
        /// <c>post_payment</c> credit note means it was issued when the invoice was paid.
        /// One of: <c>mixed</c>, <c>post_payment</c>, or <c>pre_payment</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The time that the credit note was voided.
        /// </summary>
        [JsonProperty("voided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("voided_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
