namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditNote : StripeEntity<CreditNote>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

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

        [JsonProperty("discount_amount")]
        public long DiscountAmount { get; set; }

        #region Expandable Invoice

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

        [JsonProperty("lines")]
        public StripeList<CreditNoteLineItem> Lines { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("out_of_band_amount")]
        public long? OutOfBandAmount { get; set; }

        [JsonProperty("pdf")]
        public string Pdf { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        #region Expandable Refund

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

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subtotal")]
        public long Subtotal { get; set; }

        [JsonProperty("tax_amounts")]
        public List<CreditNoteTaxAmount> TaxAmounts { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("voided_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
