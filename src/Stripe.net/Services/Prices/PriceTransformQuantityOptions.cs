namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceTransformQuantityOptions : INestedOptions
    {
        [JsonProperty("divide_by")]
        public long? DivideBy { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }
    }
}
