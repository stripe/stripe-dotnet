using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanCreateOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }
        
        [JsonProperty("interval_count")]
        public int? IntervalCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
