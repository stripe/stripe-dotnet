namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SourceBancontactCreateOptions : INestedOptions
    {
        [JsonProperty("preferred_language")]
        [STJS.JsonPropertyName("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
