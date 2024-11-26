// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceRecurringListOptions : INestedOptions
    {
        /// <summary>
        /// Filter by billing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif
        public string Interval { get; set; }

        /// <summary>
        /// Filter by the price's meter.
        /// </summary>
        [JsonProperty("meter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter")]
#endif
        public string Meter { get; set; }

        /// <summary>
        /// Filter by the usage type for this price. Can be either <c>metered</c> or
        /// <c>licensed</c>.
        /// One of: <c>licensed</c>, or <c>metered</c>.
        /// </summary>
        [JsonProperty("usage_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_type")]
#endif
        public string UsageType { get; set; }
    }
}
