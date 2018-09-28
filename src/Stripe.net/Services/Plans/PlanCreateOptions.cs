namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PlanCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("id")]
        public string Id { get; set; }

        [FormProperty("active")]
        public bool? Active { get; set; }

        [FormProperty("aggregate_usage")]
        public string AggregateUsage { get; set; }

        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("interval")]
        public string Interval { get; set; }

        [FormProperty("interval_count")]
        public int? IntervalCount { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("nickname")]
        public string Nickname { get; set; }

        [FormProperty("product")]
        public PlanProductCreateOptions Product { get; set; }

        [FormProperty("product")]
        public string ProductId { get; set; }

        [FormProperty("tiers")]
        public List<PlanTierOptions> Tiers { get; set; }

        [FormProperty("tiers_mode")]
        public string TiersMode { get; set; }

        [FormProperty("transform_usage")]
        public PlanTransformUsageOptions TransformUsage { get; set; }

        [FormProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        [FormProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
