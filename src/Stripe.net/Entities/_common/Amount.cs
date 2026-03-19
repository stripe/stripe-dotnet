namespace Stripe.V2
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class Amount
    {
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public long Value { get; set; }

        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
