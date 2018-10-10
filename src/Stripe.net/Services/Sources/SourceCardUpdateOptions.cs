namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceCardUpdateOptions : INestedOptions
    {
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }
    }
}
