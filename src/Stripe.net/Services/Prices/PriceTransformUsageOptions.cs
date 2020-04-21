namespace Stripe
{
    using Newtonsoft.Json;

    public class PriceTransformUsageOptions : INestedOptions
    {
        [JsonProperty("divide_by")]
        public long? DivideBy { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }
    }
}
