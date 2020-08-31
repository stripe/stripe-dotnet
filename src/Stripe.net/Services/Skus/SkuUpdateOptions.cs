namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SkuUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether this SKU is available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A dictionary of attributes and values for the attributes defined by the product. When
        /// specified, <c>attributes</c> will partially update the existing attributes dictionary on
        /// the product, with the postcondition that a value must be present for each attribute key
        /// on the product.
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The URL of an image for this SKU, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Description of the SKU's inventory.
        /// </summary>
        [JsonProperty("inventory")]
        public SkuInventoryOptions Inventory { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The dimensions of this SKU for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public SkuPackageDimensionsOptions PackageDimensions { get; set; }

        /// <summary>
        /// The cost of the item as a positive integer in the smallest currency unit (that is, 100
        /// cents to charge $1.00, or 100 to charge ¥100, Japanese Yen being a zero-decimal
        /// currency).
        /// </summary>
        [JsonProperty("price")]
        public long? Price { get; set; }

        /// <summary>
        /// The ID of the product that this SKU should belong to. The product must exist, have the
        /// same set of attribute names as the SKU's current product, and be of type <c>good</c>.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
