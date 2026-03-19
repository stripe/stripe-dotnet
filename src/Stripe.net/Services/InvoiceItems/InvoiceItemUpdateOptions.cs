// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceItemUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in cents (or local equivalent) of the charge to be applied to the
        /// upcoming invoice. If you want to apply a credit to the customer's account, pass a
        /// negative amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to the invoice item. The description is
        /// displayed in the invoice for easy tracking.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Controls whether discounts apply to this invoice item. Defaults to false for prorations
        /// or negative invoice items, and true for all other invoice items. Cannot be set to true
        /// for prorations.
        /// </summary>
        [JsonProperty("discountable")]
        [STJS.JsonPropertyName("discountable")]
        public bool? Discountable { get; set; }

        /// <summary>
        /// The coupons, promotion codes &amp; existing discounts which apply to the invoice item or
        /// invoice line item. Item discounts are applied before invoice discounts. Pass an empty
        /// string to remove previously-defined discounts.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
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
        [STJS.JsonPropertyName("period")]
        public InvoiceItemPeriodOptions Period { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The pricing information for the invoice item.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public InvoiceItemPricingOptions Pricing { get; set; }

        /// <summary>
        /// Non-negative integer. The quantity of units for the invoice item. Use
        /// <c>quantity_decimal</c> instead to provide decimal precision. This field will be
        /// deprecated in favor of <c>quantity_decimal</c> in a future version.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Non-negative decimal with at most 12 decimal places. The quantity of units for the line
        /// item.
        /// </summary>
        [JsonProperty("quantity_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("quantity_decimal")]
        public decimal? QuantityDecimal { get; set; }

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
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
        [STJS.JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// The tax rates which apply to the invoice item. When set, the <c>default_tax_rates</c> on
        /// the invoice do not apply to this invoice item. Pass an empty string to remove
        /// previously-defined tax rates.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// The decimal unit amount in cents (or local equivalent) of the charge to be applied to
        /// the upcoming invoice. This <c>unit_amount_decimal</c> will be multiplied by the quantity
        /// to get the full amount. Passing in a negative <c>unit_amount_decimal</c> will reduce the
        /// <c>amount_due</c> on the invoice. Accepts at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
