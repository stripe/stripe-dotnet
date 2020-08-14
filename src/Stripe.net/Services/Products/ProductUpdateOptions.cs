namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ProductUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the product is available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A list of up to 5 alphanumeric attributes that each SKU can provide values for (e.g.,
        /// <c>["color", "size"]</c>). If a value for <c>attributes</c> is specified, the list
        /// specified will replace the existing attributes list on this product. Any attributes not
        /// present after the update will be deleted from the SKUs for this product.
        /// </summary>
        [JsonProperty("attributes")]
        public List<string> Attributes { get; set; }

        /// <summary>
        /// A short one-line description of the product, meant to be displayable to the customer.
        /// May only be set if <c>type=good</c>.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// An array of Connect application names or identifiers that should not be able to order
        /// the SKUs for this product. May only be set if <c>type=good</c>.
        /// </summary>
        [JsonProperty("deactivate_on")]
        public List<string> DeactivateOn { get; set; }

        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the
        /// customer.
        /// </summary>
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product's name, meant to be displayable to the customer. Whenever this product is
        /// sold via a subscription, name will show up on associated invoice line item descriptions.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes. A SKU associated with this product
        /// can override this value by having its own <c>package_dimensions</c>. May only be set if
        /// <c>type=good</c>.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public ProductPackageDimensionsOptions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e., physical goods). Defaults to <c>true</c>. May
        /// only be set if <c>type=good</c>.
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your customer's credit card or bank statement.
        /// While most banks display this information consistently, some may display it incorrectly
        /// or not at all.
        ///
        /// This may be up to 22 characters. The statement description may not include <c>&lt;</c>,
        /// <c>&gt;</c>, <c>\</c>, <c>"</c>, <c>'</c> characters, and will appear on your customer's
        /// statement in capital letters. Non-ASCII characters are automatically stripped. It must
        /// contain at least one letter. May only be set if <c>type=service</c>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A label that represents units of this product in Stripe and on customers’ receipts and
        /// invoices. When set, this will be included in associated invoice line item descriptions.
        /// May only be set if <c>type=service</c>.
        /// </summary>
        [JsonProperty("unit_label")]
        public string UnitLabel { get; set; }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product. May only be set if
        /// <c>type=good</c>.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
