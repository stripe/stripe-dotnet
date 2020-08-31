namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceItemUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in <strong>%s</strong> of the charge to be applied to the upcoming
        /// invoice. If you want to apply a credit to the customer's account, pass a negative
        /// amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to the invoice item. The description is
        /// displayed in the invoice for easy tracking.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Controls whether discounts apply to this invoice item. Defaults to false for prorations
        /// or negative invoice items, and true for all other invoice items. Cannot be set to true
        /// for prorations.
        /// </summary>
        [JsonProperty("discountable")]
        public bool? Discountable { get; set; }

        /// <summary>
        /// The coupons &amp; existing discounts which apply to the invoice item or invoice line
        /// item. Item discounts are applied before invoice discounts. Pass an empty string to
        /// remove previously-defined discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The period associated with this invoice item.
        /// </summary>
        [JsonProperty("period")]
        public InvoiceItemPeriodOptions Period { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Non-negative integer. The quantity of units for the invoice item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the invoice item. When set, the <c>default_tax_rates</c> on
        /// the invoice do not apply to this invoice item. Pass an empty string to remove
        /// previously-defined tax rates.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// The integer unit amount in <strong>%s</strong> of the charge to be applied to the
        /// upcoming invoice. This unit_amount will be multiplied by the quantity to get the full
        /// amount. If you want to apply a credit to the customer's account, pass a negative
        /// unit_amount.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value with at most 12 decimal places.
        /// Only one of <c>unit_amount</c> and <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
