namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceIdealCreateOptions : INestedOptions
    {
        [JsonProperty("bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank")]
#endif
        public string Bank { get; set; }
    }
}
