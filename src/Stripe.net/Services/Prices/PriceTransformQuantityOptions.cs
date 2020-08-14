namespace Stripe
{
    using Newtonsoft.Json;

    public class PriceTransformQuantityOptions : INestedOptions
    {
        [JsonProperty("divide_by")]
        public long? DivideBy { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }
    }
}
