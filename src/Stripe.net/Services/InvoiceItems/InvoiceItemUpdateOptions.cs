namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceItemUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in cents of the charge to be applied to the upcoming invoice. If you
        /// want to apply a credit to the customer’s account, pass a negative amount.
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
        /// Controls whether discounts apply to this invoice item. Defaults to <c>false</c> for
        /// prorations or negative invoice items, and <c>true</c> for all other invoice items.
        /// </summary>
        [JsonProperty("discountable")]
        public bool? Discountable { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice item. If not specified, inherits
        /// the discount from the invoice's customer. Pass an empty string to avoid inheriting any
        /// discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an object. It can be useful for storing
        /// additional information about the object in a structured format.
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
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Non-negative integer. The quantity of units for the invoice item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the invoice item. When set, the <see cref="Invoice.DefaultTaxRates"/>
        /// on the invoice do not apply to this invoice item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// The integer unit amount in cents of the charge to be applied to the upcoming invoice.
        /// This value will be multiplied by the quantity to get the full amount. If you want to
        /// apply a credit to the customer’s account, pass a negative value.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <see cref="UnitAmount"/>, but accepts a decimal value with at most 12 decimal
        /// places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
