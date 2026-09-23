namespace Stripe.V2
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class AddressOptions : Stripe.AddressOptions
    {
        [JsonProperty("town")]
        [STJS.JsonPropertyName("town")]
        public string Town { get; set; }
    }
}
