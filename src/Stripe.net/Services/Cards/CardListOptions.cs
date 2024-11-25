namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardListOptions : ListOptions
    {
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("object")]
#endif
        internal string Object => "card";
    }
}
