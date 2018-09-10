namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeSourceCardUpdateOptions : INestedOptions
    {
        [JsonProperty("exp_month")]
        public int? ExpirationMonth { get; set; }

        [JsonProperty("exp_year")]
        public int? ExpirationYear { get; set; }
    }
}
