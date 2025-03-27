// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the price can be used for new purchases. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_scheme")]
#endif
        public string BillingScheme { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Prices defined in each available currency option. Each key must be a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a> and a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency_options")]
#endif
        public Dictionary<string, PriceCurrencyOptionsOptions> CurrencyOptions { get; set; }

        /// <summary>
        /// When set, provides configuration for the amount to be adjusted by the customer during
        /// Checkout Sessions and Payment Links.
        /// </summary>
        [JsonProperty("custom_unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_unit_amount")]
#endif
        public PriceCustomUnitAmountOptions CustomUnitAmount { get; set; }

        /// <summary>
        /// A lookup key used to retrieve prices dynamically from a static string. This may be up to
        /// 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A brief description of the price, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nickname")]
#endif
        public string Nickname { get; set; }

        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/products">Product</a> that this <a
        /// href="https://docs.stripe.com/api/prices">Price</a> will belong to.
        /// </summary>
        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
#endif
        public string Product { get; set; }

        /// <summary>
        /// These fields can be used to create a new product that this price will belong to.
        /// </summary>
        [JsonProperty("product_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_data")]
#endif
        public PriceProductDataOptions ProductData { get; set; }

        /// <summary>
        /// The recurring components of a price such as <c>interval</c> and <c>usage_type</c>.
        /// </summary>
        [JsonProperty("recurring")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recurring")]
#endif
        public PriceRecurringOptions Recurring { get; set; }

        /// <summary>
        /// Only required if a <a
        /// href="https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)">default
        /// tax behavior</a> was not provided in the Stripe Tax settings. Specifies whether the
        /// price is considered inclusive of taxes or exclusive of taxes. One of <c>inclusive</c>,
        /// <c>exclusive</c>, or <c>unspecified</c>. Once specified as either <c>inclusive</c> or
        /// <c>exclusive</c>, it cannot be changed.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_behavior")]
#endif
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires <c>billing_scheme</c> to
        /// be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        /// </summary>
        [JsonProperty("tiers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tiers")]
#endif
        public List<PriceTierOptions> Tiers { get; set; }

        /// <summary>
        /// Defines if the tiering price should be <c>graduated</c> or <c>volume</c> based. In
        /// <c>volume</c>-based tiering, the maximum quantity within a period determines the per
        /// unit price, in <c>graduated</c> tiering pricing can successively change as the quantity
        /// grows.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiers_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tiers_mode")]
#endif
        public string TiersMode { get; set; }

        /// <summary>
        /// If set to true, will atomically remove the lookup key from the existing price, and
        /// assign it to this price.
        /// </summary>
        [JsonProperty("transfer_lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_lookup_key")]
#endif
        public bool? TransferLookupKey { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the billed
        /// price. Cannot be combined with <c>tiers</c>.
        /// </summary>
        [JsonProperty("transform_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transform_quantity")]
#endif
        public PriceTransformQuantityOptions TransformQuantity { get; set; }

        /// <summary>
        /// A positive integer in cents (or local equivalent) (or 0 for a free price) representing
        /// how much to charge. One of <c>unit_amount</c>, <c>unit_amount_decimal</c>, or
        /// <c>custom_unit_amount</c> is required, unless <c>billing_scheme=tiered</c>.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value in cents (or local equivalent)
        /// with at most 12 decimal places. Only one of <c>unit_amount</c> and
        /// <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }
    }
}
