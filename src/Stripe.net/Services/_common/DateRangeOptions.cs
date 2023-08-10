namespace Stripe
{
    using System;
    using Newtonsoft.Json;

/* Unmerged change from project 'Stripe.net(netcoreapp3.1)'
Before:
    using Stripe.Infrastructure;
    using Newtonsoft.Json.Converters;
After:
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;
*/
    using Newtonsoft.Json.Converters;
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
