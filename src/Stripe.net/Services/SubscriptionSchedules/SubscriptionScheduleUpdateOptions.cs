namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Object representing the subscription schedule's default settings.
        /// </summary>
        [JsonProperty("default_settings")]
        public SubscriptionScheduleDefaultSettingsOptions DefaultSettings { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends. Possible
        /// values are <c>cancel</c>, <c>none</c>, <c>release</c> and <c>renew</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription schedule object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// List representing phases of the subscription schedule. Each phase can be customized to
        /// have different durations, plans, and coupons. If there are multiple phases, the
        /// <c>end_date</c> of one phase will always equal the <c>start_date</c> of the
        /// next phase.
        /// </summary>
        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }

        /// <summary>
        /// If the update changes the current phase, indicates if the changes should be prorated.
        /// Defaults to <c>true</c>.
        /// </summary>
        [Obsolete("Use ProrationBehavior instead")]
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// If the update changes the current phase, indicates if the changes should be prorated.
        /// Valid values are <c>create_prorations</c> or <c>none</c>, and the default value is
        /// <c>create_prorations</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
