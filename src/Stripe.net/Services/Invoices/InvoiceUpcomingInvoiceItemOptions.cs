namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceUpcomingInvoiceItemOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountable")]
        public bool? Discountable { get; set; }

        [JsonProperty("discounts")]
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        [JsonProperty("invoiceitem")]
        [AllowNameMismatch]
        public string InvoiceItem { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("period")]
        public InvoiceItemPeriodOptions Period { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
