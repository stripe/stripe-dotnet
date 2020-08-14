namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("default_settings")]
        public SubscriptionScheduleDefaultSettingsOptions DefaultSettings { get; set; }

        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }

        [Obsolete("Use ProrationBehavior instead.")]
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
