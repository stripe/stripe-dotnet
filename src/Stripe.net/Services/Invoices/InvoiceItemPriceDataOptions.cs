namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceItemPriceDataOptions : INestedOptions
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
