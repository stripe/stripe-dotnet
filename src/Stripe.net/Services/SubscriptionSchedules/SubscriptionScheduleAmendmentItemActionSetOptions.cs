// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionSetOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("discounts")]
        public List<SubscriptionScheduleAmendmentItemActionSetDiscountOptions> Discounts { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        [JsonProperty("trial")]
        public SubscriptionScheduleAmendmentItemActionSetTrialOptions Trial { get; set; }
    }
}
