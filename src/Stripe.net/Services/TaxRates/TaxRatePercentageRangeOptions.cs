namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class TaxRatePercentageRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        [STJS.JsonPropertyName("gt")]
        [AllowNameMismatch]
        public decimal? GreaterThan { get; set; }

        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        [AllowNameMismatch]
        public decimal? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        [STJS.JsonPropertyName("lt")]
        [AllowNameMismatch]
        public decimal? LessThan { get; set; }

        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        [AllowNameMismatch]
        public decimal? LessThanOrEqual { get; set; }
    }
}
