namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AddressJapanOptions : AddressOptions
    {
        [JsonProperty("town")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("town")]
#endif
        public string Town { get; set; }
    }
}
