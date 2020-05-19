namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerBalanceTransaction : StripeEntity<CustomerBalanceTransaction>, IHasId, IHasMetadata, IHasObject
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

        #region Expandable Credit Note

        [JsonIgnore]
        public string CreditNoteId
        {
            get => this.InternalCreditNote?.Id;
            set => this.InternalCreditNote = SetExpandableFieldId(value, this.InternalCreditNote);
        }

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

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ending_balance")]
        public long EndingBalance { get; set; }

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

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
