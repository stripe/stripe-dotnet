namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class PriceTransformUsageOptions : INestedOptions
    {
        [JsonProperty("divide_by")]
        [STJS.JsonPropertyName("divide_by")]
        public long? DivideBy { get; set; }

        [JsonProperty("round")]
        [STJS.JsonPropertyName("round")]
        public string Round { get; set; }
    }
}
