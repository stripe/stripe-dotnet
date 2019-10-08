namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TaxRatePercentageRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        [AllowNameMismatch]
        public decimal? GreaterThan { get; set; }

        [JsonProperty("gte")]
        [AllowNameMismatch]
        public decimal? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        [AllowNameMismatch]
        public decimal? LessThan { get; set; }

        [JsonProperty("lte")]
        [AllowNameMismatch]
        public decimal? LessThanOrEqual { get; set; }
    }
}
