namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_data")]
        public SubscriptionItemPriceDataOptions PriceData { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ProrationDate { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
