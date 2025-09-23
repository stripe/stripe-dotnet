// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesSubscriptionUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The types of subscription updates that are supported. When empty, subscriptions are not
        /// updateable.
        /// One of: <c>price</c>, <c>promotion_code</c>, or <c>quantity</c>.
        /// </summary>
        [JsonProperty("default_allowed_updates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_allowed_updates")]
#endif
        public List<string> DefaultAllowedUpdates { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// The list of up to 10 products that support subscription updates.
        /// </summary>
        [JsonProperty("products")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("products")]
#endif
        public List<ConfigurationFeaturesSubscriptionUpdateProductOptions> Products { get; set; }

        /// <summary>
        /// Determines how to handle prorations resulting from subscription updates. Valid values
        /// are <c>none</c>, <c>create_prorations</c>, and <c>always_invoice</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Setting to control when an update should be scheduled at the end of the period instead
        /// of applying immediately.
        /// </summary>
        [JsonProperty("schedule_at_period_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule_at_period_end")]
#endif
        public ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndOptions ScheduleAtPeriodEnd { get; set; }

        /// <summary>
        /// The behavior when updating a subscription that is trialing.
        /// One of: <c>continue_trial</c>, or <c>end_trial</c>.
        /// </summary>
        [JsonProperty("trial_update_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_update_behavior")]
#endif
        public string TrialUpdateBehavior { get; set; }
    }
}
