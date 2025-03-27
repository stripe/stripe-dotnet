namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceAuBecsDebitCreateOptions : INestedOptions
    {
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        [JsonProperty("bsb_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bsb_number")]
#endif
        public string BsbNumber { get; set; }
    }
}
