namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditNote : StripeEntity, IHasId, IHasMetadata, IHasObject
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
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            get
            {
                return this.Customer ?? (object)this.CustomerId;
            }

            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        #region Expandable Invoice

        /// <summary>
        /// ID of the invoice associated with that credit note.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId { get; set; }

        [JsonIgnore]
        public Invoice Invoice { get; set; }

        [JsonProperty("invoice")]
        internal object InternalInvoice
        {
            get
            {
                return this.Invoice ?? (object)this.InvoiceId;
            }

            set
            {
                StringOrObject<Invoice>.Map(value, s => this.InvoiceId = s, o => this.Invoice = o);
            }
        }
        #endregion

        /// <summary>
        /// Has the value <code>true</code> if the object exists in live mode or the value
        /// <code>false</code> if the object exists in test mode.
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
        /// The link to download the PDF of the credit note.
        /// </summary>
        [JsonProperty("pdf")]
        public string Pdf { get; set; }

        /// <summary>
        /// Reason for issuing this credit note, one of <code>duplicate</code>,
        /// <code>fraudulent</code>, <code>order_change</code>, or
        /// <code>product_unsatisfactory</code>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        #region Expandable Refund

        /// <summary>
        /// ID of the refund associated with that credit note.
        /// </summary>
        [JsonIgnore]
        public string RefundId { get; set; }

        [JsonIgnore]
        public Refund Refund { get; set; }

        [JsonProperty("refund")]
        internal object InternalRefund
        {
            get
            {
                return this.Refund ?? (object)this.RefundId;
            }

            set
            {
                StringOrObject<Refund>.Map(value, s => this.RefundId = s, o => this.Refund = o);
            }
        }
        #endregion

        /// <summary>
        /// Status of this credit note, one of <code>issued</code> or <code>void</code>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of this credit note, one of <code>post_payment</code> or <code>pre_payment</code>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
