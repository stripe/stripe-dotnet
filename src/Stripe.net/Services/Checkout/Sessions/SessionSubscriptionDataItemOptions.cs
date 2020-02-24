namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionSubscriptionDataItemOptions : INestedOptions
    {
        /// <summary>
        /// Plan ID for this item.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to this item. When set, the default tax
        /// rates on subscription data do not apply to this item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
