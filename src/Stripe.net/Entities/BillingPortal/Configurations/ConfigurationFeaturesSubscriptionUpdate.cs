// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesSubscriptionUpdate : StripeEntity<ConfigurationFeaturesSubscriptionUpdate>
    {
        /// <summary>
        /// Determines the value to use for the billing cycle anchor on subscription updates. Valid
        /// values are <c>now</c> or <c>unchanged</c>, and the default value is <c>unchanged</c>.
        /// Setting the value to <c>now</c> resets the subscription's billing cycle anchor to the
        /// current time (in UTC). For more information, see the billing cycle <a
        /// href="https://docs.stripe.com/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>now</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// The types of subscription updates that are supported for items listed in the
        /// <c>products</c> attribute. When empty, subscriptions are not updateable.
        /// One of: <c>price</c>, <c>promotion_code</c>, or <c>quantity</c>.
        /// </summary>
        [JsonProperty("default_allowed_updates")]
        [STJS.JsonPropertyName("default_allowed_updates")]
        public List<string> DefaultAllowedUpdates { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The list of up to 10 products that support subscription updates.
        /// </summary>
        [JsonProperty("products")]
        [STJS.JsonPropertyName("products")]
        public List<ConfigurationFeaturesSubscriptionUpdateProduct> Products { get; set; }

        /// <summary>
        /// Determines how to handle prorations resulting from subscription updates. Valid values
        /// are <c>none</c>, <c>create_prorations</c>, and <c>always_invoice</c>. Defaults to a
        /// value of <c>none</c> if you don't set it during creation.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("schedule_at_period_end")]
        [STJS.JsonPropertyName("schedule_at_period_end")]
        public ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd ScheduleAtPeriodEnd { get; set; }

        /// <summary>
        /// Determines how handle updates to trialing subscriptions. Valid values are
        /// <c>end_trial</c> and <c>continue_trial</c>. Defaults to a value of <c>end_trial</c> if
        /// you don't set it during creation.
        /// One of: <c>continue_trial</c>, or <c>end_trial</c>.
        /// </summary>
        [JsonProperty("trial_update_behavior")]
        [STJS.JsonPropertyName("trial_update_behavior")]
        public string TrialUpdateBehavior { get; set; }
    }
}
