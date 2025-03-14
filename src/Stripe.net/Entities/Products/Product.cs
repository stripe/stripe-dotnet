// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Products describe the specific goods or services you offer to your customers. For
    /// example, you might offer a Standard and Premium version of your goods or service; each
    /// version would be a separate Product. They can be used in conjunction with <a
    /// href="https://stripe.com/docs/api#prices">Prices</a> to configure pricing in Payment
    /// Links, Checkout, and Subscriptions.
    ///
    /// Related guides: <a
    /// href="https://stripe.com/docs/billing/subscriptions/set-up-subscription">Set up a
    /// subscription</a>, <a href="https://stripe.com/docs/payment-links">share a Payment
    /// Link</a>, <a
    /// href="https://stripe.com/docs/payments/accept-a-payment#create-product-prices-upfront">accept
    /// payments with Checkout</a>, and more about <a
    /// href="https://stripe.com/docs/products-prices/overview">Products and Prices</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Product : StripeEntity<Product>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Whether the product is currently available for purchase.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool Active { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable DefaultPrice

        /// <summary>
        /// (ID of the Price)
        /// The ID of the <a href="https://stripe.com/docs/api/prices">Price</a> object that is the
        /// default price for this product.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DefaultPriceId
        {
            get => this.InternalDefaultPrice?.Id;
            set => this.InternalDefaultPrice = SetExpandableFieldId(value, this.InternalDefaultPrice);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the <a href="https://stripe.com/docs/api/prices">Price</a> object that is the
        /// default price for this product.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Price DefaultPrice
        {
            get => this.InternalDefaultPrice?.ExpandedObject;
            set => this.InternalDefaultPrice = SetExpandableFieldObject(value, this.InternalDefaultPrice);
        }

        [JsonProperty("default_price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_price")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Price>))]
#endif
        internal ExpandableField<Price> InternalDefaultPrice { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the
        /// customer.
        /// </summary>
        [JsonProperty("images")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("images")]
#endif
        public List<string> Images { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// A list of up to 15 marketing features for this product. These are displayed in <a
        /// href="https://stripe.com/docs/payments/checkout/pricing-table">pricing tables</a>.
        /// </summary>
        [JsonProperty("marketing_features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketing_features")]
#endif
        public List<ProductMarketingFeature> MarketingFeatures { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product's name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("package_dimensions")]
#endif
        public ProductPackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Provisioning configuration for this product.
        /// </summary>
        [JsonProperty("provisioning")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("provisioning")]
#endif
        public ProductProvisioning Provisioning { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e., physical goods).
        /// </summary>
        [JsonProperty("shippable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shippable")]
#endif
        public bool? Shippable { get; set; }

        /// <summary>
        /// Extra information about a product which will appear on your customer's credit card
        /// statement. In the case that multiple products are billed at once, the first statement
        /// descriptor will be used. Only used for subscription payments.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        #region Expandable TaxCode

        /// <summary>
        /// (ID of the TaxCode)
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string TaxCodeId
        {
            get => this.InternalTaxCode?.Id;
            set => this.InternalTaxCode = SetExpandableFieldId(value, this.InternalTaxCode);
        }

        /// <summary>
        /// (Expanded)
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public TaxCode TaxCode
        {
            get => this.InternalTaxCode?.ExpandedObject;
            set => this.InternalTaxCode = SetExpandableFieldObject(value, this.InternalTaxCode);
        }

        [JsonProperty("tax_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxCode>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TaxCode>))]
#endif
        internal ExpandableField<TaxCode> InternalTaxCode { get; set; }
        #endregion

        /// <summary>
        /// The type of the product. The product is either of type <c>good</c>, which is eligible
        /// for use with Orders and SKUs, or <c>service</c>, which is eligible for use with
        /// Subscriptions and Plans.
        /// One of: <c>good</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// A label that represents units of this product. When set, this will be included in
        /// customers' receipts, invoices, Checkout, and the customer portal.
        /// </summary>
        [JsonProperty("unit_label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_label")]
#endif
        public string UnitLabel { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
