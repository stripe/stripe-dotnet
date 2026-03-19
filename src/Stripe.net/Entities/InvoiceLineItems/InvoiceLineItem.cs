// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Invoice Line Items represent the individual lines within an <a
    /// href="https://docs.stripe.com/api/invoices">invoice</a> and only exist within the
    /// context of an invoice.
    ///
    /// Each line item is backed by either an <a
    /// href="https://docs.stripe.com/api/invoiceitems">invoice item</a> or a <a
    /// href="https://docs.stripe.com/api/subscription_items">subscription item</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItem : StripeEntity<InvoiceLineItem>, IHasId, IHasMetadata, IHasObject
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
        /// The amount, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The amount of discount calculated per discount for this line item.
        /// </summary>
        [JsonProperty("discount_amounts")]
        [STJS.JsonPropertyName("discount_amounts")]
        public List<InvoiceLineItemDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// If true, discounts will apply to this line item. Always false for prorations.
        /// </summary>
        [JsonProperty("discountable")]
        [STJS.JsonPropertyName("discountable")]
        public bool Discountable { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to the invoice line item. Line item discounts are applied before
        /// invoice discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        [STJS.JsonPropertyName("discounts")]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The ID of the invoice that contains this line item.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The amount of margin calculated per margin for this line item.
        /// </summary>
        [JsonProperty("margin_amounts")]
        [STJS.JsonPropertyName("margin_amounts")]
        public List<InvoiceLineItemMarginAmount> MarginAmounts { get; set; }

        #region Expandable Margins

        /// <summary>
        /// (IDs of the Margins)
        /// The margins applied to the line item. When set, the <c>default_margins</c> on the
        /// invoice do not apply to the line item. Use <c>expand[]=margins</c> to expand each
        /// margin.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> MarginIds
        {
            get => this.InternalMargins?.Select((x) => x.Id).ToList();
            set => this.InternalMargins = SetExpandableArrayIds<Margin>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The margins applied to the line item. When set, the <c>default_margins</c> on the
        /// invoice do not apply to the line item. Use <c>expand[]=margins</c> to expand each
        /// margin.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Margin> Margins
        {
            get => this.InternalMargins?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalMargins = SetExpandableArrayObjects(value);
        }

        [JsonProperty("margins", ItemConverterType = typeof(ExpandableFieldConverter<Margin>))]
        [STJS.JsonPropertyName("margins")]
        internal List<ExpandableField<Margin>> InternalMargins { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Note that for line items with <c>type=subscription</c>,
        /// <c>metadata</c> reflects the current metadata from the subscription associated with the
        /// line item, unless the invoice line was directly updated with different metadata after
        /// creation.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The parent that generated this line item.
        /// </summary>
        [JsonProperty("parent")]
        [STJS.JsonPropertyName("parent")]
        public InvoiceLineItemParent Parent { get; set; }

        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public InvoiceLineItemPeriod Period { get; set; }

        /// <summary>
        /// Contains pretax credit amounts (ex: discount, credit grants, etc) that apply to this
        /// line item.
        /// </summary>
        [JsonProperty("pretax_credit_amounts")]
        [STJS.JsonPropertyName("pretax_credit_amounts")]
        public List<InvoiceLineItemPretaxCreditAmount> PretaxCreditAmounts { get; set; }

        /// <summary>
        /// The pricing information of the line item.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public InvoiceLineItemPricing Pricing { get; set; }

        /// <summary>
        /// The quantity of the subscription, if the line item is a subscription or a proration.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        #region Expandable Subscription

        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        [JsonIgnore]
        [STJS.JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        /// <summary>
        /// The subtotal of the line item, in cents (or local equivalent), before any discounts or
        /// taxes.
        /// </summary>
        [JsonProperty("subtotal")]
        [STJS.JsonPropertyName("subtotal")]
        public long Subtotal { get; set; }

        /// <summary>
        /// The tax calculation identifiers of the line item.
        /// </summary>
        [JsonProperty("tax_calculation_reference")]
        [STJS.JsonPropertyName("tax_calculation_reference")]
        public InvoiceLineItemTaxCalculationReference TaxCalculationReference { get; set; }

        /// <summary>
        /// The tax information of the line item.
        /// </summary>
        [JsonProperty("taxes")]
        [STJS.JsonPropertyName("taxes")]
        public List<InvoiceLineItemTax> Taxes { get; set; }
    }
}
