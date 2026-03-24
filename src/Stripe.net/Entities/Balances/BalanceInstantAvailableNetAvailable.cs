// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceInstantAvailableNetAvailable : StripeEntity<BalanceInstantAvailableNetAvailable>
    {
        /// <summary>
        /// Net balance amount, subtracting fees from platform-set pricing.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// ID of the external account for this net balance (not expandable).
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }

        [JsonProperty("source_types")]
        [STJS.JsonPropertyName("source_types")]
        public BalanceInstantAvailableNetAvailableSourceTypes SourceTypes { get; set; }
    }
}
