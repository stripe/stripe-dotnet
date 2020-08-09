namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemSubscriptionItemPriceDataRecurringOptions : ListOptions
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
