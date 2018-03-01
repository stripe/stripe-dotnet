using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeProductSharedOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// Whether or not the product is currently available for purchase. Defaults to true.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A list of up to 5 alphanumeric attributes that each SKU can provide values for (e.g. ["color", "size"]).
        /// </summary>
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        /// <summary>
        /// A short one-line description of the product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// An array of Connect application names or identifiers that should not be able to order the SKUs for this product.
        /// </summary>
        [JsonProperty("deactivate_on")]
        public string[] DeactivateOn { get; set; }

        /// <summary>
        /// The product’s description, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("images")]
        public string[] Images { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a product object. It can be useful for storing additional information about the product in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// REQUIRED: The product’s name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes. A SKU associated with this product can override this value by having its own package_dimensions.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public StripePackageDimensionOptions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e. physical goods). Defaults to true.
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// What appears on the customers credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
