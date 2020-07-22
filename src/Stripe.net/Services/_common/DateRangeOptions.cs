namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DateRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("gte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThan { get; set; }

        [JsonProperty("lte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
