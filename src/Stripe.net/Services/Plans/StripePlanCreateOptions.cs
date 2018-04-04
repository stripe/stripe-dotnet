using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public int? IntervalCount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("product")]
        public StripePlanProductCreateOptions Product { get; set; }

        [JsonProperty("product")]
        public string ProductId { get; set; }

        [JsonProperty("tiers_array")]
        public List<StripePlanTierOptions> Tiers { get; set; }

        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        [JsonProperty("transform_usage")]
        public StripePlanTransformUsageOptions TransformUsage { get; set; }

        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
