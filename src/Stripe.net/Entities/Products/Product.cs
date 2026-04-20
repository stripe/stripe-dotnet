// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Products describe the specific goods or services you offer to your customers. For
    /// example, you might offer a Standard and Premium version of your goods or service; each
    /// version would be a separate Product. They can be used in conjunction with <a
    /// href="https://api.stripe.com#prices">Prices</a> to configure pricing in Payment Links,
    /// Checkout, and Subscriptions.
    ///
    /// Related guides: <a
    /// href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a
    /// subscription</a>, <a href="https://docs.stripe.com/payment-links">share a Payment
    /// Link</a>, <a
    /// href="https://docs.stripe.com/payments/accept-a-payment#create-product-prices-upfront">accept
    /// payments with Checkout</a>, and more about <a
    /// href="https://docs.stripe.com/products-prices/overview">Products and Prices</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Product : StripeEntity<Product>, IHasId, IHasMetadata, IHasObject
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

        /// <summary>
        /// Whether the product is currently available for purchase.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable DefaultPrice

        /// <summary>
        /// (ID of the Price)
        /// The ID of the <a href="https://docs.stripe.com/api/prices">Price</a> object that is the
        /// default price for this product.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string DefaultPriceId
        {
            get => this.InternalDefaultPrice?.Id;
            set => this.InternalDefaultPrice = SetExpandableFieldId(value, this.InternalDefaultPrice);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the <a href="https://docs.stripe.com/api/prices">Price</a> object that is the
        /// default price for this product.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Price DefaultPrice
        {
            get => this.InternalDefaultPrice?.ExpandedObject;
            set => this.InternalDefaultPrice = SetExpandableFieldObject(value, this.InternalDefaultPrice);
        }

        [JsonProperty("default_price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        [STJS.JsonPropertyName("default_price")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalDefaultPrice { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the
        /// customer.
        /// </summary>
        [JsonProperty("images")]
        [STJS.JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A list of up to 15 marketing features for this product. These are displayed in <a
        /// href="https://docs.stripe.com/payments/checkout/pricing-table">pricing tables</a>.
        /// </summary>
        [JsonProperty("marketing_features")]
        [STJS.JsonPropertyName("marketing_features")]
        public List<ProductMarketingFeature> MarketingFeatures { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product's name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
        [STJS.JsonPropertyName("package_dimensions")]
        public ProductPackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e., physical goods).
        /// </summary>
        [JsonProperty("shippable")]
        [STJS.JsonPropertyName("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Extra information about a product which will appear on your customer's credit card
        /// statement. In the case that multiple products are billed at once, the first statement
        /// descriptor will be used. Only used for subscription payments.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        #region Expandable TaxCode

        /// <summary>
        /// (ID of the TaxCode)
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string TaxCodeId
        {
            get => this.InternalTaxCode?.Id;
            set => this.InternalTaxCode = SetExpandableFieldId(value, this.InternalTaxCode);
        }

        /// <summary>
        /// (Expanded)
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public TaxCode TaxCode
        {
            get => this.InternalTaxCode?.ExpandedObject;
            set => this.InternalTaxCode = SetExpandableFieldObject(value, this.InternalTaxCode);
        }

        [JsonProperty("tax_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxCode>))]
        [STJS.JsonPropertyName("tax_code")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TaxCode>))]
        internal ExpandableField<TaxCode> InternalTaxCode { get; set; }
        #endregion

        /// <summary>
        /// Tax details for this product, including the <a
        /// href="https://stripe.com/tax/tax-codes">tax code</a> and an optional performance
        /// location.
        /// </summary>
        [JsonProperty("tax_details")]
        [STJS.JsonPropertyName("tax_details")]
        public ProductTaxDetails TaxDetails { get; set; }

        /// <summary>
        /// The type of the product. The product is either of type <c>good</c>, which is eligible
        /// for use with Orders and SKUs, or <c>service</c>, which is eligible for use with
        /// Subscriptions and Plans.
        /// One of: <c>good</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// A label that represents units of this product. When set, this will be included in
        /// customers' receipts, invoices, Checkout, and the customer portal.
        /// </summary>
        [JsonProperty("unit_label")]
        [STJS.JsonPropertyName("unit_label")]
        public string UnitLabel { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("updated")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
