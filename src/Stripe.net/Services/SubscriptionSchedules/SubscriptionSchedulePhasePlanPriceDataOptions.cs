namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class SubscriptionSchedulePhasePlanPriceDataOptions : INestedOptions
    {
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        [JsonProperty("recurring")]
        [STJS.JsonPropertyName("recurring")]
        public SubscriptionSchedulePhasePlanPriceDataRecurringOptions Recurring { get; set; }

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
