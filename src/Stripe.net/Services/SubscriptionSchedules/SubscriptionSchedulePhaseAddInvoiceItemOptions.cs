namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseAddInvoiceItemOptions : INestedOptions
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_data")]
        public SubscriptionSchedulePhaseAddInvoiceItemPriceDataOptions PriceData { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
