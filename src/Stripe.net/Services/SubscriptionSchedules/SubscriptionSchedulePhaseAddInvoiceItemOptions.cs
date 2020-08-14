namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseAddInvoiceItemOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
        public SubscriptionSchedulePhaseAddInvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item. Defaults to 1.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
