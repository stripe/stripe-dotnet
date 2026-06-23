namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SourceIdealCreateOptions : INestedOptions
    {
        [JsonProperty("bank")]
        [STJS.JsonPropertyName("bank")]
        public string Bank { get; set; }
    }
}
