// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A line item.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class LineItem : StripeEntity<LineItem>, IHasId, IHasMetadata, IHasObject
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

        [JsonProperty("adjustable_quantity")]
        [STJS.JsonPropertyName("adjustable_quantity")]
        public LineItemAdjustableQuantity AdjustableQuantity { get; set; }

        /// <summary>
        /// Total discount amount applied. If no discounts were applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_discount")]
        [STJS.JsonPropertyName("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total tax amount applied. If no tax was applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_tax")]
        [STJS.JsonPropertyName("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// Total after discounts and taxes.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Defaults to product name.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The discounts applied to the line item.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<LineItemDiscount> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The price used to generate the line item.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public Price Price { get; set; }

        /// <summary>
        /// The quantity of products being purchased.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The taxes applied to the line item.
        /// </summary>
        [JsonProperty("taxes")]
        [STJS.JsonPropertyName("taxes")]
        public List<LineItemTax> Taxes { get; set; }
    }
}
