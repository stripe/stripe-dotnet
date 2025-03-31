namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class TaxRatePercentageRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gt")]
#endif
        [AllowNameMismatch]
        public decimal? GreaterThan { get; set; }

        [JsonProperty("gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gte")]
#endif
        [AllowNameMismatch]
        public decimal? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lt")]
#endif
        [AllowNameMismatch]
        public decimal? LessThan { get; set; }

        [JsonProperty("lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lte")]
#endif
        [AllowNameMismatch]
        public decimal? LessThanOrEqual { get; set; }
    }
}
