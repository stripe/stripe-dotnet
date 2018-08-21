namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceCardUpdateOptions : INestedOptions
    {
        [JsonProperty("exp_month")]
        public int? ExpirationMonth { get; set; }

        [JsonProperty("exp_year")]
        public int? ExpirationYear { get; set; }
    }
}
