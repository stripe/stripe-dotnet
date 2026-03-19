namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SourceThreeDSecureCreateOptions : INestedOptions
    {
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public string Card { get; set; }
    }
}
