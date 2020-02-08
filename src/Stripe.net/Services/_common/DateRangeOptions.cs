namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DateRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        [JsonConverter(typeof(DateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("gte")]
        [JsonConverter(typeof(DateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        [JsonConverter(typeof(DateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThan { get; set; }

        [JsonProperty("lte")]
        [JsonConverter(typeof(DateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
