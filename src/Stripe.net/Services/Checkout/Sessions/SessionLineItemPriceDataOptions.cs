namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionLineItemPriceDataOptions : INestedOptions
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("product_data")]
        public SessionLineItemPriceDataProductDataOptions ProductData { get; set; }

        [JsonProperty("recurring")]
        public SessionLineItemPriceDataRecurringOptions Recurring { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
