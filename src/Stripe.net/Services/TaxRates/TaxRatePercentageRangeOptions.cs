namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class TaxRatePercentageRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        public decimal? GreaterThan { get; set; }

        [JsonProperty("gte")]
        public decimal? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        public decimal? LessThan { get; set; }

        [JsonProperty("lte")]
        public decimal? LessThanOrEqual { get; set; }
    }
}
