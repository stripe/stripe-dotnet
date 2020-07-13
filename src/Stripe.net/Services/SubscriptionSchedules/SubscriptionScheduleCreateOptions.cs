namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The identifier of the customer to create the subscription schedule for.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

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
        /// Migrate an existing subscription to be managed by a subscription schedule. If this
        /// parameter is set, a subscription schedule will be created using the subscription's
        /// plan(s), set to auto-renew using the subscription's interval. Other parameters cannot
        /// be set since their values will be inferred from the subscription.
        /// </summary>
        [JsonProperty("from_subscription")]
        public string FromSubscription { get; set; }

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
        /// The date at which the subscription schedule starts.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionScheduleStartDate> StartDate { get; set; }
    }
}
