namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PlanUpdateOptions : BaseOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("product")]
        public string ProductId { get; set; }

        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
