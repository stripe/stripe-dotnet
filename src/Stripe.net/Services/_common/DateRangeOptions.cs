namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class DateRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("gt")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("gte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("gte")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("lt")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThan { get; set; }

        [JsonProperty("lte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("lte")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        [AllowNameMismatch]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
