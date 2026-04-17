// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProductUpdateOptions : BaseOptions, IHasMetadata
    {
        private string description;
        private List<string> images;
        private List<ProductMarketingFeatureOptions> marketingFeatures;
        private Dictionary<string, string> metadata;
        private ProductPackageDimensionsOptions packageDimensions;
        private string taxCode;
        private ProductTaxDetailsOptions taxDetails;
        private string unitLabel;
        private string url;

        /// <summary>
        /// Whether the product is available for purchase.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/prices">Price</a> object that is the
        /// default price for this product.
        /// </summary>
        [JsonProperty("default_price")]
        [STJS.JsonPropertyName("default_price")]
        public string DefaultPrice { get; set; }

        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("description")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Description
        {
            get => this.description;
            set
            {
                this.description = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the
        /// customer.
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("images")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Images
        {
            get => this.images;
            set
            {
                this.images = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A list of up to 15 marketing features for this product. These are displayed in <a
        /// href="https://docs.stripe.com/payments/checkout/pricing-table">pricing tables</a>.
        /// </summary>
        [JsonProperty("marketing_features", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("marketing_features")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<ProductMarketingFeatureOptions> MarketingFeatures
        {
            get => this.marketingFeatures;
            set
            {
                this.marketingFeatures = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The product's name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("package_dimensions")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ProductPackageDimensionsOptions PackageDimensions
        {
            get => this.packageDimensions;
            set
            {
                this.packageDimensions = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether this product is shipped (i.e., physical goods).
        /// </summary>
        [JsonProperty("shippable")]
        [STJS.JsonPropertyName("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your customer's credit card or bank statement.
        /// While most banks display this information consistently, some may display it incorrectly
        /// or not at all.
        ///
        /// This may be up to 22 characters. The statement description may not include <c>&lt;</c>,
        /// <c>&gt;</c>, <c>\</c>, <c>"</c>, <c>'</c> characters, and will appear on your customer's
        /// statement in capital letters. Non-ASCII characters are automatically stripped. It must
        /// contain at least one letter. May only be set if <c>type=service</c>. Only used for
        /// subscription payments.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tax_code")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string TaxCode
        {
            get => this.taxCode;
            set
            {
                this.taxCode = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Tax details for this product, including the <a
        /// href="https://stripe.com/tax/tax-codes">tax code</a> and an optional performance
        /// location.
        /// </summary>
        [JsonProperty("tax_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tax_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ProductTaxDetailsOptions TaxDetails
        {
            get => this.taxDetails;
            set
            {
                this.taxDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A label that represents units of this product. When set, this will be included in
        /// customers' receipts, invoices, Checkout, and the customer portal. May only be set if
        /// <c>type=service</c>.
        /// </summary>
        [JsonProperty("unit_label", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("unit_label")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string UnitLabel
        {
            get => this.unitLabel;
            set
            {
                this.unitLabel = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("url")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Url
        {
            get => this.url;
            set
            {
                this.url = value;
                this.SetTracker.Track();
            }
        }
    }
}
