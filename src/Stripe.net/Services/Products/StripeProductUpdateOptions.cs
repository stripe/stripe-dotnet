using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeProductUpdateOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not the product is currently available for purchase. Defaults to true.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets a list of up to 5 alphanumeric attributes that each SKU can provide values for (e.g. ["color", "size"]).
        /// Optional
        /// </summary>
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        /// <summary>
        /// Gets or sets a short one-line description of the product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets the product’s description, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of up to 8 URLs of images for this product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("images")]
        public string[] Images { get; set; }

        /// <summary>
        /// Gets or sets a set of key/value pairs that you can attach to a product object. It can be useful for storing additional information about the product in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the product’s name, meant to be displayable to the customer.
        /// REQUIRED in create. Optional for update
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of this product for shipping purposes. A SKU associated with this product can override this value by having its own package_dimensions
        /// </summary>
        [JsonProperty("package_dimensions")]
        public StripeDimensionsOptions PackageDimensions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this product is shipped (i.e. physical goods). Defaults to true.
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Gets or sets a URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
