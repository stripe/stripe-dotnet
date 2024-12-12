namespace Stripe
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class DateRangeOptions : INestedOptions
    {
        [JsonProperty("gt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gt")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        [AllowNameMismatch]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("gte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gte")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        [AllowNameMismatch]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("lt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lt")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        [AllowNameMismatch]
        public DateTime? LessThan { get; set; }

        [JsonProperty("lte")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lte")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        [AllowNameMismatch]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
