// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Prices define the unit cost, currency, and (optional) billing cycle for both recurring
    /// and one-time purchases of products. <a
    /// href="https://api.stripe.com#products">Products</a> help you track inventory or
    /// provisioning, and prices help you track payment terms. Different physical goods or
    /// levels of service should be represented by products, and pricing options should be
    /// represented by prices. This approach lets you change prices without having to change
    /// your provisioning scheme.
    ///
    /// For example, you might have a single "gold" product that has prices for $10/month,
    /// $100/year, and €9 once.
    ///
    /// Related guides: <a
    /// href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a
    /// subscription</a>, <a href="https://docs.stripe.com/billing/invoices/create">create an
    /// invoice</a>, and more about <a
    /// href="https://docs.stripe.com/products-prices/overview">products and prices</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Price : StripeEntity<Price>, IHasId, IHasMetadata, IHasObject
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
        /// Whether the price can be used for new purchases.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Describes how to compute the price per period. Either <c>per_unit</c> or <c>tiered</c>.
        /// <c>per_unit</c> indicates that the fixed amount (specified in <c>unit_amount</c> or
        /// <c>unit_amount_decimal</c>) will be charged per unit in <c>quantity</c> (for prices with
        /// <c>usage_type=licensed</c>), or per unit of total usage (for prices with
        /// <c>usage_type=metered</c>). <c>tiered</c> indicates that the unit pricing will be
        /// computed using a tiering strategy as defined using the <c>tiers</c> and
        /// <c>tiers_mode</c> attributes.
        /// One of: <c>per_unit</c>, or <c>tiered</c>.
        /// </summary>
        [JsonProperty("billing_scheme")]
        [STJS.JsonPropertyName("billing_scheme")]
        public string BillingScheme { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Prices defined in each available currency option. Each key must be a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a> and a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options")]
        [STJS.JsonPropertyName("currency_options")]
        public Dictionary<string, PriceCurrencyOptions> CurrencyOptions { get; set; }

        /// <summary>
        /// When set, provides configuration for the amount to be adjusted by the customer during
        /// Checkout Sessions and Payment Links.
        /// </summary>
        [JsonProperty("custom_unit_amount")]
        [STJS.JsonPropertyName("custom_unit_amount")]
        public PriceCustomUnitAmount CustomUnitAmount { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// A custom identifier for this price, such as a SKU number or product code, that can be
        /// used to reference records from external systems.
        /// </summary>
        [JsonProperty("external_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("external_reference")]
#endif
        public string ExternalReference { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A lookup key used to retrieve prices dynamically from a static string. This may be up to
        /// 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Subscriptions using this price will be migrated to use the new referenced price.
        /// </summary>
        [JsonProperty("migrate_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("migrate_to")]
#endif
        public PriceMigrateTo MigrateTo { get; set; }

        /// <summary>
        /// A brief description of the price, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        [STJS.JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        #region Expandable Product

        /// <summary>
        /// (ID of the Product)
        /// The ID of the product this price is associated with.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ProductId
        {
            get => this.InternalProduct?.Id;
            set => this.InternalProduct = SetExpandableFieldId(value, this.InternalProduct);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the product this price is associated with.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonProperty("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
        [STJS.JsonPropertyName("product")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Product>))]
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        /// <summary>
        /// The recurring components of a price such as <c>interval</c> and <c>usage_type</c>.
        /// </summary>
        [JsonProperty("recurring")]
        [STJS.JsonPropertyName("recurring")]
        public PriceRecurring Recurring { get; set; }

        /// <summary>
        /// Only required if a <a
        /// href="https://docs.stripe.com/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)">default
        /// tax behavior</a> was not provided in the Stripe Tax settings. Specifies whether the
        /// price is considered inclusive of taxes or exclusive of taxes. One of <c>inclusive</c>,
        /// <c>exclusive</c>, or <c>unspecified</c>. Once specified as either <c>inclusive</c> or
        /// <c>exclusive</c>, it cannot be changed.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires <c>billing_scheme</c> to
        /// be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        /// </summary>
        [JsonProperty("tiers")]
        [STJS.JsonPropertyName("tiers")]
        public List<PriceTier> Tiers { get; set; }

        /// <summary>
        /// Defines if the tiering price should be <c>graduated</c> or <c>volume</c> based. In
        /// <c>volume</c>-based tiering, the maximum quantity within a period determines the per
        /// unit price. In <c>graduated</c> tiering, pricing can change as the quantity grows.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiers_mode")]
        [STJS.JsonPropertyName("tiers_mode")]
        public string TiersMode { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed. Cannot be combined with <c>tiers</c>.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public PriceTransformQuantity TransformQuantity { get; set; }

        /// <summary>
        /// One of <c>one_time</c> or <c>recurring</c> depending on whether the price is for a
        /// one-time purchase or a recurring (subscription) purchase.
        /// One of: <c>one_time</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The unit amount in cents (or local equivalent) to be charged, represented as a whole
        /// integer if possible. Only set if <c>billing_scheme=per_unit</c>.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// The unit amount in cents (or local equivalent) to be charged, represented as a decimal
        /// string with at most 12 decimal places. Only set if <c>billing_scheme=per_unit</c>.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
