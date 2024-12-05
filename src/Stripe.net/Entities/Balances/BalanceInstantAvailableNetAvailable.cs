// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class BalanceInstantAvailableNetAvailable : StripeEntity<BalanceInstantAvailableNetAvailable>
    {
        /// <summary>
        /// Net balance amount, subtracting fees from platform-set pricing.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// ID of the external account for this net balance (not expandable).
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("source_types")]
        public BalanceInstantAvailableNetAvailableSourceTypes SourceTypes { get; set; }
    }
}
