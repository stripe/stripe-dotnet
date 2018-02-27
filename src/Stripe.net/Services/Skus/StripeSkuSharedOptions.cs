using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeSkuSharedOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// Whether or not the SKU is currently available for purchase. Defaults to true.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A dictionary of attributes and values for the attributes defined by the product. If, for example, a product’s attributes are ["size", "gender"], a valid SKU has the following dictionary of attributes: {"size": "Medium", "gender": "Unisex"}.
        /// This dictionary encoding is handled in a custom parser in DictionaryPlugin.cs
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The URL of an image for this SKU, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("image")]
        public string image { get; set; }

        /// <summary>
        /// Description of the SKU’s inventory.
        /// </summary>
        [JsonProperty("inventory")]
        public StripeInventoryOptions Inventory { get; set; }

        /// <summary>
        /// Set of key/value pairs that you can attach to an object. It can be useful for storing additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The dimensions of this SKU for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public StripePackageDimensionOptions PackageDimensions { get; set; }

        /// <summary>
        /// The cost of the item as a positive integer in the smallest currency unit (that is, 100 cents to charge $1.00, or 100 to charge ¥100, Japanese Yen being a 0-decimal currency).
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// The ID of the product this SKU is associated with. The product must be currently active.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
