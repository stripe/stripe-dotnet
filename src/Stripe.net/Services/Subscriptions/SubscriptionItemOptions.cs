namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemOptions : INestedOptions, IHasId, IHasMetadata
    {
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_data")]
        public SubscriptionItemPriceDataOptions PriceData { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
