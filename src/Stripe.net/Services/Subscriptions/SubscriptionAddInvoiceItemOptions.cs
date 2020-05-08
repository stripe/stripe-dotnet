namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionAddInvoiceItemOptions : INestedOptions
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
