namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceRecurringListOptions : INestedOptions
    {
        /// <summary>
        /// Filter by billing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Filter by the usage type for this price. Can be either <c>metered</c> or
        /// <c>licensed</c>.
        /// </summary>
        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
