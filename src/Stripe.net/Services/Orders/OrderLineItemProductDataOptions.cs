// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderLineItemProductDataOptions : INestedOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A unique identifier for this product.
        ///
        /// <c>product_data</c> automatically creates a Product with this ID. If a Product with the
        /// same ID already exists, then <c>product_data</c> re-uses it to avoid duplicates. If any
        /// of the fields in the existing Product are different from the values in
        /// <c>product_data</c>, <c>product_data</c> updates the existing Product with the new
        /// information. So set <c>product_data[id]</c> to the same string every time you sell the
        /// same product, but don't re-use the same string for different products.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

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
        /// The product's name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public OrderLineItemProductDataPackageDimensionsOptions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e., physical goods).
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
