namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SourceAuBecsDebitCreateOptions : INestedOptions
    {
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bsb_number")]
        [STJS.JsonPropertyName("bsb_number")]
        public string BsbNumber { get; set; }
    }
}
