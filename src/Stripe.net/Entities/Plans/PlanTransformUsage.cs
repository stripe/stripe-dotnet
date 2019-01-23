namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTransformUsage : StripeEntity<PlanTransformUsage>
    {
        [JsonProperty("divide_by")]
        public long DivideBy { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }
    }
}
