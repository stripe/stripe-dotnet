namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class ChargeSourceListOptions : INestedOptions, IHasObject
    {
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }
    }
}
