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
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
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
        /// The amount of margin calculated per margin for this line item.
        /// </summary>
        [JsonProperty("margin_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("margin_amounts")]
#endif
        public List<InvoiceLineItemMarginAmount> MarginAmounts { get; set; }

        #region Expandable Margins

        /// <summary>
        /// (IDs of the Margins)
        /// The margins applied to the line item. When set, the <c>default_margins</c> on the
        /// invoice do not apply to the line item. Use <c>expand[]=margins</c> to expand each
        /// margin.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<Margin> Margins
        {
            get => this.InternalMargins?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalMargins = SetExpandableArrayObjects(value);
        }

        [JsonProperty("margins", ItemConverterType = typeof(ExpandableFieldConverter<Margin>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("margins")]
#endif
        internal List<ExpandableField<Margin>> InternalMargins { get; set; }
        #endregion

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

        [JsonProperty("parent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("parent")]
#endif
        public InvoiceLineItemParent Parent { get; set; }

        [JsonProperty("period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("period")]
#endif
        public InvoiceLineItemPeriod Period { get; set; }

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
        /// The pricing information of the line item.
        /// </summary>
        [JsonProperty("pricing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing")]
#endif
        public InvoiceLineItemPricing Pricing { get; set; }

        /// <summary>
        /// The quantity of the subscription, if the line item is a subscription or a proration.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        #region Expandable Subscription

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

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
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
#endif
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        /// <summary>
        /// The tax calculation identifiers of the line item.
        /// </summary>
        [JsonProperty("tax_calculation_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_calculation_reference")]
#endif
        public InvoiceLineItemTaxCalculationReference TaxCalculationReference { get; set; }

        /// <summary>
        /// The tax information of the line item.
        /// </summary>
        [JsonProperty("taxes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxes")]
#endif
        public List<InvoiceLineItemTax> Taxes { get; set; }
    }
}
