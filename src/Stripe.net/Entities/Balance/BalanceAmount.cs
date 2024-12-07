namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceAmount : StripeEntity<BalanceAmount>
    {
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        [JsonProperty("source_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_types")]
#endif
        public Dictionary<string, long> SourceTypes { get; set; }
    }
}
