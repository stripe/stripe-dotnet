// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemTrial : StripeEntity<SubscriptionItemTrial>
    {
        /// <summary>
        /// List of price IDs which, if present on the subscription following a paid trial,
        /// constitute opting-in to the paid trial.
        /// </summary>
        [JsonProperty("converts_to")]
        public List<string> ConvertsTo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
