namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceTransformUsageOptions : INestedOptions
    {
        [JsonProperty("divide_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("divide_by")]
#endif
        public long? DivideBy { get; set; }

        [JsonProperty("round")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("round")]
#endif
        public string Round { get; set; }
    }
}
