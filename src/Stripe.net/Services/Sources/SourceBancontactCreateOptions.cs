namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceBancontactCreateOptions : INestedOptions
    {
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
