using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanTransformUsageOptions : INestedOptions
    {
        [JsonProperty("transform_usage[divide_by]")]
        public int DivideBy { get; set; }

        [JsonProperty("transform_usage[round]")]
        public string Round { get; set; }
    }
}