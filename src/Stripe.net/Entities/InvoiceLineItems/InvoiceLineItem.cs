// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Invoice Line Items represent the individual lines within an <a
    /// href="https://stripe.com/docs/api/invoices">invoice</a> and only exist within the
    /// context of an invoice.
    ///
    /// Each line item is backed by either an <a
    /// href="https://stripe.com/docs/api/invoiceitems">invoice item</a> or a <a
    /// href="https://stripe.com/docs/api/subscription_items">subscription item</a>.
    /// </summary>
    public class InvoiceLineItem : StripeEntity<InvoiceLineItem>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The amount, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the amount for this line
        /// item, excluding all tax and discounts.
        /// </summary>
        [JsonProperty("amount_excluding_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_excluding_tax")]
#endif
        public long? AmountExcludingTax { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The amount of discount calculated per discount for this line item.
        /// </summary>
        [JsonProperty("discount_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amounts")]
#endif
        public List<InvoiceLineItemDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// If true, discounts will apply to this line item. Always false for prorations.
        /// </summary>
        [JsonProperty("discountable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discountable")]
#endif
        public bool Discountable { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to the invoice line item. Line item discounts are applied before
        /// invoice discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("discounts")]
#endif
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The ID of the invoice that contains this line item.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        #region Expandable InvoiceItem

        /// <summary>
        /// (ID of the InvoiceItem)
        /// The ID of the <a href="https://stripe.com/docs/api/invoiceitems">invoice item</a>
        /// associated with this line item if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string InvoiceItemId
        {
            get => this.InternalInvoiceItem?.Id;
            set => this.InternalInvoiceItem = SetExpandableFieldId(value, this.InternalInvoiceItem);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the <a href="https://stripe.com/docs/api/invoiceitems">invoice item</a>
        /// associated with this line item if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public InvoiceItem InvoiceItem
        {
            get => this.InternalInvoiceItem?.ExpandedObject;
            set => this.InternalInvoiceItem = SetExpandableFieldObject(value, this.InternalInvoiceItem);
        }

        [JsonProperty("invoice_item")]
        [JsonConverter(typeof(ExpandableFieldConverter<InvoiceItem>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("invoice_item")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<InvoiceItem>))]
#endif
        internal ExpandableField<InvoiceItem> InternalInvoiceItem { get; set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Note that for line items with <c>type=subscription</c>,
        /// <c>metadata</c> reflects the current metadata from the subscription associated with the
        /// line item, unless the invoice line was directly updated with different metadata after
        /// creation.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("period")]
#endif
        public InvoiceLineItemPeriod Period { get; set; }

        /// <summary>
        /// The plan of the subscription, if the line item is a subscription or a proration.
        /// </summary>
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public Plan Plan { get; set; }

        /// <summary>
        /// Contains pretax credit amounts (ex: discount, credit grants, etc) that apply to this
        /// line item.
        /// </summary>
        [JsonProperty("pretax_credit_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pretax_credit_amounts")]
#endif
        public List<InvoiceLineItemPretaxCreditAmount> PretaxCreditAmounts { get; set; }

        /// <summary>
        /// The price of the line item.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public Price Price { get; set; }

        /// <summary>
        /// Whether this is a proration.
        /// </summary>
        [JsonProperty("proration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration")]
#endif
        public bool Proration { get; set; }

        /// <summary>
        /// Additional details for proration line items.
        /// </summary>
        [JsonProperty("proration_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_details")]
#endif
        public InvoiceLineItemProrationDetails ProrationDetails { get; set; }

        /// <summary>
        /// The quantity of the subscription, if the line item is a subscription or a proration.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription that the invoice item pertains to, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription that the invoice item pertains to, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
#endif
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        #region Expandable SubscriptionItem

        /// <summary>
        /// (ID of the SubscriptionItem)
        /// The subscription item that generated this line item. Left empty if the line item is not
        /// an explicit result of a subscription.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SubscriptionItemId
        {
            get => this.InternalSubscriptionItem?.Id;
            set => this.InternalSubscriptionItem = SetExpandableFieldId(value, this.InternalSubscriptionItem);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription item that generated this line item. Left empty if the line item is not
        /// an explicit result of a subscription.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public SubscriptionItem SubscriptionItem
        {
            get => this.InternalSubscriptionItem?.ExpandedObject;
            set => this.InternalSubscriptionItem = SetExpandableFieldObject(value, this.InternalSubscriptionItem);
        }

        [JsonProperty("subscription_item")]
        [JsonConverter(typeof(ExpandableFieldConverter<SubscriptionItem>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("subscription_item")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SubscriptionItem>))]
#endif
        internal ExpandableField<SubscriptionItem> InternalSubscriptionItem { get; set; }
        #endregion

        /// <summary>
        /// The amount of tax calculated per tax rate for this line item.
        /// </summary>
        [JsonProperty("tax_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_amounts")]
#endif
        public List<InvoiceLineItemTaxAmount> TaxAmounts { get; set; }

        /// <summary>
        /// The tax rates which apply to the line item.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// A string identifying the type of the source of this line item, either an
        /// <c>invoiceitem</c> or a <c>subscription</c>.
        /// One of: <c>invoiceitem</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The amount in cents (or local equivalent) representing the unit amount for this line
        /// item, excluding all tax and discounts.
        /// </summary>
        [JsonProperty("unit_amount_excluding_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_excluding_tax")]
#endif
        public decimal? UnitAmountExcludingTax { get; set; }
    }
}
