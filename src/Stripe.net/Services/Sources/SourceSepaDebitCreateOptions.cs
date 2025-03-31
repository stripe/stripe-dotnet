namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceSepaDebitCreateOptions : INestedOptions
    {
        [JsonProperty("iban")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban")]
#endif
        public string Iban { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public string Ideal { get; set; }
    }
}
