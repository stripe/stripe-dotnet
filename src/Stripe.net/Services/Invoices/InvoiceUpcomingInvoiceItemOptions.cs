namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceUpcomingInvoiceItemOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("discountable")]
        [STJS.JsonPropertyName("discountable")]
        public bool? Discountable { get; set; }

        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        [JsonProperty("invoiceitem")]
        [STJS.JsonPropertyName("invoiceitem")]
        [AllowNameMismatch]
        public string InvoiceItem { get; set; }

        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public InvoiceItemPeriodOptions Period { get; set; }

        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }

        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonConverter(typeof(DecimalStringConverter))]
        [JsonProperty("unit_amount_decimal")]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
