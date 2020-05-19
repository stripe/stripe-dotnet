namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceRecurringOptions : INestedOptions
    {
        [JsonProperty("aggregate_usage")]
        public string AggregateUsage { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }

        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
