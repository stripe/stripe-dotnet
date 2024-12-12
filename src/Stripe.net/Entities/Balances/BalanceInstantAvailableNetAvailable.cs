// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceInstantAvailableNetAvailable : StripeEntity<BalanceInstantAvailableNetAvailable>
    {
        /// <summary>
        /// Net balance amount, subtracting fees from platform-set pricing.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// ID of the external account for this net balance (not expandable).
        /// </summary>
        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif
        public string Destination { get; set; }

        [JsonProperty("source_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_types")]
#endif
        public BalanceInstantAvailableNetAvailableSourceTypes SourceTypes { get; set; }
    }
}
