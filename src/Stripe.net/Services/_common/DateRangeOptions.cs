namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class DateRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("gte")]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        public DateTime? LessThan { get; set; }

        [JsonProperty("lte")]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
