namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceItem : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer
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

        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountable")]
        public bool Discountable { get; set; }

        #region Expandable Invoice
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

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        [JsonProperty("proration")]
        public bool Proration { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        #region Expandable Subscription
        [JsonIgnore]
        public string SubscriptionId { get; set; }

        [JsonIgnore]
        public Subscription Subscription { get; set; }

        [JsonProperty("subscription")]
        internal object InternalSubscription
        {
            get
            {
                return this.Subscription ?? (object)this.SubscriptionId;
            }

            set
            {
                StringOrObject<Subscription>.Map(value, s => this.SubscriptionId = s, o => this.Subscription = o);
            }
        }
        #endregion

        [JsonProperty("subscription_item")]
        public string SubscriptionItemId { get; set; }

        /// <summary>
        /// The tax rates which apply to the invoice item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }
    }
}
