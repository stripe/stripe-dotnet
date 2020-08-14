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
        /// Configures how the subscription schedule behaves when it ends. Possible values are
        /// <c>release</c> or <c>cancel</c> with the default being <c>release</c>. <c>release</c>
        /// will end the subscription schedule and keep the underlying subscription
        /// running.<c>cancel</c> will end the subscription schedule and cancel the underlying
        /// subscription.
        /// One of: <c>cancel</c>, <c>none</c>, <c>release</c>, or <c>renew</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// List representing phases of the subscription schedule. Each phase can be customized to
        /// have different durations, plans, and coupons. If there are multiple phases, the
        /// <c>end_date</c> of one phase will always equal the <c>start_date</c> of the next phase.
        /// Note that past phases can be omitted.
        /// </summary>
        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }

        /// <summary>
        /// This field has been renamed to <c>proration_behavior</c>. <c>prorate=true</c> can be
        /// replaced with <c>proration_behavior=create_prorations</c> and <c>prorate=false</c> can
        /// be replaced with <c>proration_behavior=none</c>.
        /// </summary>
        [Obsolete("Use ProrationBehavior instead.")]
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// If the update changes the current phase, indicates if the changes should be prorated.
        /// Possible values are <c>create_prorations</c> or <c>none</c>, and the default value is
        /// <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
