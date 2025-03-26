namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceBancontactCreateOptions : INestedOptions
    {
        [JsonProperty("preferred_language")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_language")]
#endif
        public string PreferredLanguage { get; set; }
    }
}
