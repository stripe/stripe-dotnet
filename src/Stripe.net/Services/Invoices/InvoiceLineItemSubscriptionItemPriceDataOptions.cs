namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemSubscriptionItemPriceDataOptions : ListOptions
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("recurring")]
        public InvoiceLineItemSubscriptionItemPriceDataRecurringOptions Recurring { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
