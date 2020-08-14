namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemPriceDataOptions : INestedOptions
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("recurring")]
        public SubscriptionItemPriceDataRecurringOptions Recurring { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
