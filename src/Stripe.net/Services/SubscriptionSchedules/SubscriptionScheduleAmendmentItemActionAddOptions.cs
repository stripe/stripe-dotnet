// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionAddOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("discounts")]
        public List<SubscriptionScheduleAmendmentItemActionAddDiscountOptions> Discounts { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        [JsonProperty("trial")]
        public SubscriptionScheduleAmendmentItemActionAddTrialOptions Trial { get; set; }
    }
}
