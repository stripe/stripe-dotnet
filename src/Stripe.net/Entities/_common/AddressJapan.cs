namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AddressJapan : Address
    {
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("town")]
#else
        [JsonProperty("town")]
#endif
        public string Town { get; set; }
    }
}
