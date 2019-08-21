namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DateRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("gte")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? LessThan { get; set; }

        [JsonProperty("lte")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
