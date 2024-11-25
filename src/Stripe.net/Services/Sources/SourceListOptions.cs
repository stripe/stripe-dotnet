namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceListOptions : ListOptions
    {
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("object")]
#endif
        internal string Object => "source";

        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
