// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PriceRecurringListOptions : INestedOptions
    {
        /// <summary>
        /// Filter by billing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Filter by the usage type for this price. Can be either <c>metered</c> or
        /// <c>licensed</c>.
        /// One of: <c>licensed</c>, or <c>metered</c>.
        /// </summary>
        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
