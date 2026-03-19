namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class BalanceAmount : StripeEntity<BalanceAmount>
    {
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("source_types")]
        [STJS.JsonPropertyName("source_types")]
        public Dictionary<string, long> SourceTypes { get; set; }
    }
}
