using System.Collections.Generic;

using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Base class for sku requests.
    /// </summary>
    public abstract class StripeSkuOptionsBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not the SKU is available for purchase. Default to true.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets a dictionary of attributes and values for the attributes defined by the product. If, for example, a product’s attributes are ["size", "gender"], a valid SKU has the following dictionary of attributes: {"size": "Medium", "gender": "Unisex"}.
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets a 3-letter ISO code for currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the URL of an image for this SKU, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets a description of the SKU’s inventory.
        /// </summary>
        [JsonProperty("inventory")]
        public StripeInventoryOptions Inventory { get; set; }

        /// <summary>
        /// Gets or sets a set of key/value pairs that you can attach to a SKU object. It can be useful for storing additional information about the SKU in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of this SKU for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public StripeDimensionsOptions PackageDimensions { get; set; }

        /// <summary>
        /// Gets or sets the ID of the product this SKU is associated with.
        /// </summary>
        [JsonProperty("product")]
        public string ProductId { get; set; }
    }
}
