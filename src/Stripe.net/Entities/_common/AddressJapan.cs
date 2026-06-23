namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class AddressJapan : Address
    {
        [JsonProperty("town")]
        [STJS.JsonPropertyName("town")]
        public string Town { get; set; }
    }
}
