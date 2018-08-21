namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTransformUsageOptions : INestedOptions
    {
        [JsonProperty("divide_by")]
        public int DivideBy { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }
    }
}
