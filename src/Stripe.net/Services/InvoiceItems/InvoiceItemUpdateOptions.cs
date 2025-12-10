// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in cents (or local equivalent) of the charge to be applied to the
        /// upcoming invoice. If you want to apply a credit to the customer's account, pass a
        /// negative amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to the invoice item. The description is
        /// displayed in the invoice for easy tracking.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Controls whether discounts apply to this invoice item. Defaults to false for prorations
        /// or negative invoice items, and true for all other invoice items. Cannot be set to true
        /// for prorations.
        /// </summary>
        [JsonProperty("discountable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discountable")]
#endif
        public bool? Discountable { get; set; }

        /// <summary>
        /// The coupons, promotion codes &amp; existing discounts which apply to the invoice item or
        /// invoice line item. Item discounts are applied before invoice discounts. Pass an empty
        /// string to remove previously-defined discounts.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
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
        /// The period associated with this invoice item. When set to different values, the period
        /// will be rendered on the invoice. If you have <a
        /// href="https://docs.stripe.com/revenue-recognition">Stripe Revenue Recognition</a>
        /// enabled, the period will be used to recognize and defer revenue. See the <a
        /// href="https://docs.stripe.com/revenue-recognition/methodology/subscriptions-and-invoicing">Revenue
        /// Recognition documentation</a> for details.
        /// </summary>
        [JsonProperty("period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("period")]
#endif
        public InvoiceItemPeriodOptions Period { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_data")]
#endif
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The pricing information for the invoice item.
        /// </summary>
        [JsonProperty("pricing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing")]
#endif
        public InvoiceItemPricingOptions Pricing { get; set; }

        /// <summary>
        /// Non-negative integer. The quantity of units for the invoice item.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_behavior")]
#endif
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }

        /// <summary>
        /// The tax rates which apply to the invoice item. When set, the <c>default_tax_rates</c> on
        /// the invoice do not apply to this invoice item. Pass an empty string to remove
        /// previously-defined tax rates.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// The decimal unit amount in cents (or local equivalent) of the charge to be applied to
        /// the upcoming invoice. This <c>unit_amount_decimal</c> will be multiplied by the quantity
        /// to get the full amount. Passing in a negative <c>unit_amount_decimal</c> will reduce the
        /// <c>amount_due</c> on the invoice. Accepts at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }
    }
}
