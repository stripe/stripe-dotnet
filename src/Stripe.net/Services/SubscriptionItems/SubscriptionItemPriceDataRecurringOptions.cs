namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemPriceDataRecurringOptions : INestedOptions
    {
/// <summary>
        /// Specifies a usage aggregation strategy for prices where <see cref="UsageType"/> is
        /// <c>metered</c>. Allowed values are <c>sum</c> for summing up all usage during a period,
        /// <c>last_during_period</c> for picking the last usage record reported within a period,
        /// <c>last_ever</c> for picking the last usage record ever (across period bounds) or
        /// <c>max</c> which picks the usage record with the maximum reported usage during a
        /// period. Defaults to <c>sum</c>.
        /// </summary>
        [JsonProperty("aggregate_usage")]
        public string AggregateUsage { get; set; }

        /// <summary>
        /// he frequency at which a subscription is billed. One of <c>day</c>, <c>week</c>,
        /// <c>month</c> or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the <see cref="Interval"/> property) between
        /// subscription billings.
        /// </summary>
        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Default number of trial days when subscribing a customer to this price using
        /// <c>trial_from_price=true</c>.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Configures how the quantity per period should be determined, can be either
        /// <c>metered</c> or <c>licensed</c>. <c>licensed</c> will automatically bill the quantity
        /// set for a price when adding it to a subscription, <c>metered</c> will aggregate the
        /// total usage based on usage records. Defaults to <c>licensed</c>.
        /// </summary>
        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
