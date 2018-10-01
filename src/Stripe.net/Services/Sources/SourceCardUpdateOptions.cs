namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceCardUpdateOptions : INestedOptions
    {
        [JsonProperty("exp_month")]
        public int? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int? ExpYear { get; set; }
    }
}
