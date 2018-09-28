namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public abstract class ProductSharedOptions : BaseOptions, ISupportMetadata
    {
        /// <summary>
        /// Whether or not the product is currently available for purchase. Defaults to true.
        /// </summary>
        [FormProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A list of up to 5 alphanumeric attributes that each SKU can provide values for (e.g. ["color", "size"]).
        /// </summary>
        [FormProperty("attributes")]
        public string[] Attributes { get; set; }

        /// <summary>
        /// A short one-line description of the product, meant to be displayable to the customer.
        /// </summary>
        [FormProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// An array of Connect application names or identifiers that should not be able to order the SKUs for this product.
        /// </summary>
        [FormProperty("deactivate_on")]
        public string[] DeactivateOn { get; set; }

        /// <summary>
        /// The product’s description, meant to be displayable to the customer.
        /// </summary>
        [FormProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the customer.
        /// </summary>
        [FormProperty("images")]
        public string[] Images { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a product object. It can be useful for storing additional information about the product in a structured format.
        /// </summary>
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// REQUIRED: The product’s name, meant to be displayable to the customer.
        /// </summary>
        [FormProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes. A SKU associated with this product can override this value by having its own package_dimensions.
        /// </summary>
        [FormProperty("package_dimensions")]
        public PackageDimensionOptions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e. physical goods). Defaults to true.
        /// </summary>
        [FormProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// What appears on the customers credit card statement.
        /// </summary>
        [FormProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [FormProperty("url")]
        public string Url { get; set; }
    }
}
