namespace Stripe
{
    using Newtonsoft.Json;

    public class PriceRecurringOptions : INestedOptions
    {
        /// <summary>
        /// Specifies a usage aggregation strategy for prices of <c>usage_type=metered</c>. Allowed
        /// values are <c>sum</c> for summing up all usage during a period,
        /// <c>last_during_period</c> for using the last usage record reported within a period,
        /// <c>last_ever</c> for using the last usage record ever (across period bounds) or
        /// <c>max</c> which uses the usage record with the maximum reported usage during a period.
        /// Defaults to <c>sum</c>.
        /// One of: <c>last_during_period</c>, <c>last_ever</c>, <c>max</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("aggregate_usage")]
        public string AggregateUsage { get; set; }

        /// <summary>
        /// Specifies billing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between subscription billings. For example,
        /// <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of one
        /// year interval allowed (1 year, 12 months, or 52 weeks).
        /// </summary>
        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Default number of trial days when subscribing a customer to this price using <a
        /// href="https://stripe.com/docs/api#create_subscription-trial_from_plan"><c>trial_from_plan=true</c></a>.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Configures how the quantity per period should be determined. Can be either
        /// <c>metered</c> or <c>licensed</c>. <c>licensed</c> automatically bills the
        /// <c>quantity</c> set when adding it to a subscription. <c>metered</c> aggregates the
        /// total usage based on usage records. Defaults to <c>licensed</c>.
        /// One of: <c>licensed</c>, or <c>metered</c>.
        /// </summary>
        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
