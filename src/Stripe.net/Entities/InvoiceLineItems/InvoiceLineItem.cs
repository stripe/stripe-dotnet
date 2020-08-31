namespace Stripe
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceLineItem : StripeEntity<InvoiceLineItem>, IHasId, IHasMetadata, IHasObject
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
        /// The amount, in %s.
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The amount of discount calculated per discount for this line item.
        /// </summary>
        [JsonProperty("discount_amounts")]
        public List<InvoiceLineItemDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// If true, discounts will apply to this line item. Always false for prorations.
        /// </summary>
        [JsonProperty("discountable")]
        public bool Discountable { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to the invoice line item. Line item discounts are applied before
        /// invoice discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The discounts applied to the invoice line item. Line item discounts are applied before
        /// invoice discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/api/invoiceitems">invoice item</a>
        /// associated with this line item if any.
        /// </summary>
        [JsonProperty("invoice_item")]
        public string InvoiceItem { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Note that for line items with <c>type=subscription</c>
        /// this will reflect the metadata of the subscription that caused the line item to be
        /// created.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("period")]
        public InvoiceLineItemPeriod Period { get; set; }

        /// <summary>
        /// The plan of the subscription, if the line item is a subscription or a proration.
        /// </summary>
        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// The price of the line item.
        /// </summary>
        [JsonProperty("price")]
        public Price Price { get; set; }

        /// <summary>
        /// Whether this is a proration.
        /// </summary>
        [JsonProperty("proration")]
        public bool Proration { get; set; }

        /// <summary>
        /// The quantity of the subscription, if the line item is a subscription or a proration.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The subscription that the invoice item pertains to, if any.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription item that generated this invoice item. Left empty if the line item is
        /// not an explicit result of a subscription.
        /// </summary>
        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }

        /// <summary>
        /// The amount of tax calculated per tax rate for this line item.
        /// </summary>
        [JsonProperty("tax_amounts")]
        public List<InvoiceLineItemTaxAmount> TaxAmounts { get; set; }

        /// <summary>
        /// The tax rates which apply to the line item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// A string identifying the type of the source of this line item, either an
        /// <c>invoiceitem</c> or a <c>subscription</c>.
        /// One of: <c>invoiceitem</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// For prorations this indicates whether Stripe automatically grouped multiple related
        /// debit and credit line items into a single combined line item.
        /// </summary>
        [JsonProperty("unified_proration")]
        public bool UnifiedProration { get; set; }
    }
}
