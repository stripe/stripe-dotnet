// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A line item.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class LineItem : StripeEntity<LineItem>, IHasId, IHasMetadata, IHasObject
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

        [JsonProperty("adjustable_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustable_quantity")]
#endif
        public LineItemAdjustableQuantity AdjustableQuantity { get; set; }

        /// <summary>
        /// Total discount amount applied. If no discounts were applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_discount")]
#endif
        public long AmountDiscount { get; set; }

        /// <summary>
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total tax amount applied. If no tax was applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long AmountTax { get; set; }

        /// <summary>
        /// Total after discounts and taxes.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif
        public long AmountTotal { get; set; }

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
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Defaults to product name.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The discounts applied to the line item.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<LineItemDiscount> Discounts { get; set; }

        [JsonProperty("display")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display")]
#endif
        public LineItemDisplay Display { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The price used to generate the line item.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public Price Price { get; set; }

        #region Expandable Product

        /// <summary>
        /// (ID of the Product)
        /// The ID of the product for this line item.
        ///
        /// This will always be the same as <c>price.product</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ProductId
        {
            get => this.InternalProduct?.Id;
            set => this.InternalProduct = SetExpandableFieldId(value, this.InternalProduct);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the product for this line item.
        ///
        /// This will always be the same as <c>price.product</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonProperty("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Product>))]
#endif
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        /// <summary>
        /// The quantity of products being purchased.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax calculation identifiers of the line item.
        /// </summary>
        [JsonProperty("tax_calculation_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_calculation_reference")]
#endif
        public LineItemTaxCalculationReference TaxCalculationReference { get; set; }

        /// <summary>
        /// The taxes applied to the line item.
        /// </summary>
        [JsonProperty("taxes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxes")]
#endif
        public List<LineItemTax> Taxes { get; set; }
    }
}
