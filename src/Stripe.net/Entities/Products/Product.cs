// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Products describe the specific goods or services you offer to your customers. For
    /// example, you might offer a Standard and Premium version of your goods or service; each
    /// version would be a separate Product. They can be used in conjunction with <a
    /// href="https://stripe.com/docs/api#prices">Prices</a> to configure pricing in Payment
    /// Links, Checkout, and Subscriptions.
    ///
    /// Related guides: <a
    /// href="https://stripe.com/docs/billing/subscriptions/set-up-subscription">Set up a
    /// subscription</a>, <a
    /// href="https://stripe.com/docs/payments/payment-links/overview">share a Payment Link</a>,
    /// <a
    /// href="https://stripe.com/docs/payments/accept-a-payment#create-product-prices-upfront">accept
    /// payments with Checkout</a>, and more about <a
    /// href="https://stripe.com/docs/products-prices/overview">Products and Prices</a>.
    /// </summary>
    public class Product : StripeEntity<Product>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the product is currently available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// A list of up to 5 attributes that each SKU can provide values for (e.g., <c>["color",
        /// "size"]</c>).
        /// </summary>
        [JsonProperty("attributes")]
        public List<string> Attributes { get; set; }

        /// <summary>
        /// A short one-line description of the product, meant to be displayable to the customer.
        /// Only applicable to products of <c>type=good</c>.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An array of connect application identifiers that cannot purchase this product. Only
        /// applicable to products of <c>type=good</c>.
        /// </summary>
        [JsonProperty("deactivate_on")]
        public List<string> DeactivateOn { get; set; }

        #region Expandable DefaultPrice

        /// <summary>
        /// (ID of the Price)
        /// The ID of the <a href="https://stripe.com/docs/api/prices">Price</a> object that is the
        /// default price for this product.
        /// </summary>
        [JsonIgnore]
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
        public Price DefaultPrice
        {
            get => this.InternalDefaultPrice?.ExpandedObject;
            set => this.InternalDefaultPrice = SetExpandableFieldObject(value, this.InternalDefaultPrice);
        }

        [JsonProperty("default_price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalDefaultPrice { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
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
        public ProductPackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e., physical goods).
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Extra information about a product which will appear on your customer's credit card
        /// statement. In the case that multiple products are billed at once, the first statement
        /// descriptor will be used.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        #region Expandable TaxCode

        /// <summary>
        /// (ID of the TaxCode)
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonIgnore]
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
        public TaxCode TaxCode
        {
            get => this.InternalTaxCode?.ExpandedObject;
            set => this.InternalTaxCode = SetExpandableFieldObject(value, this.InternalTaxCode);
        }

        [JsonProperty("tax_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxCode>))]
        internal ExpandableField<TaxCode> InternalTaxCode { get; set; }
        #endregion

        /// <summary>
        /// The type of the product. The product is either of type <c>good</c>, which is eligible
        /// for use with Orders and SKUs, or <c>service</c>, which is eligible for use with
        /// Subscriptions and Plans.
        /// One of: <c>good</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A label that represents units of this product. When set, this will be included in
        /// customers' receipts, invoices, Checkout, and the customer portal.
        /// </summary>
        [JsonProperty("unit_label")]
        public string UnitLabel { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
