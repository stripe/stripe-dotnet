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
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Credit note amount.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// ID of the customer associated with that credit note.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

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
        /// ID of the customer balance transaction related to this credit note.
        /// </summary>
        [JsonIgnore]
        public string CustomerBalanceTransactionId
        {
            get => this.InternalCustomerBalanceTransaction?.Id;
            set => this.InternalCustomerBalanceTransaction = SetExpandableFieldId(value, this.InternalCustomerBalanceTransaction);
        }

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
        /// The integer amount representing the amount of the discount that was credited.
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
        /// ID of the invoice associated with that credit note.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c>
        /// if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Credit note memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It can be useful for
        /// storing additional information about the order in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Credit note number.
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
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        #region Expandable Refund

        /// <summary>
        /// ID of the refund associated with that credit note.
        /// </summary>
        [JsonIgnore]
        public string RefundId
        {
            get => this.InternalRefund?.Id;
            set => this.InternalRefund = SetExpandableFieldId(value, this.InternalRefund);
        }

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
        /// Status of this credit note, one of <c>issued</c> or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The integer amount in **%s** representing the amount of the credit note, excluding tax
        /// and discount.
        /// </summary>
        [JsonProperty("subtotal")]
        public long Subtotal { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per tax rate for all line items.
        /// </summary>
        [JsonProperty("tax_amounts")]
        public List<CreditNoteTaxAmount> TaxAmounts { get; set; }

        /// <summary>
        /// The integer amount in **%s** representing the total amount of the credit note, including
        /// tax and discount.
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }

        /// <summary>
        /// Type of this credit note, one of <c>post_payment</c> or <c>pre_payment</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The time that the credit note was voided.
        /// </summary>
        [JsonProperty("voided_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
