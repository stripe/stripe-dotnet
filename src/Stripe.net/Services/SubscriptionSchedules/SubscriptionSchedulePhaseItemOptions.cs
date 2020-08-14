namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseItemOptions : INestedOptions
    {
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

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
