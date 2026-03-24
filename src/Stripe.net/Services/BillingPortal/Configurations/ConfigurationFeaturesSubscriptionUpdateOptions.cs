// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesSubscriptionUpdateOptions : INestedOptions, IHasSetTracking
    {
        private List<string> defaultAllowedUpdates;
        private List<ConfigurationFeaturesSubscriptionUpdateProductOptions> products;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

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
        /// The types of subscription updates that are supported. When empty, subscriptions are not
        /// updateable.
        /// One of: <c>price</c>, <c>promotion_code</c>, or <c>quantity</c>.
        /// </summary>
        [JsonProperty("default_allowed_updates")]
        [STJS.JsonPropertyName("default_allowed_updates")]
        public List<string> DefaultAllowedUpdates
        {
            get => this.defaultAllowedUpdates;
            set
            {
                this.defaultAllowedUpdates = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The list of up to 10 products that support subscription updates.
        /// </summary>
        [JsonProperty("products")]
        [STJS.JsonPropertyName("products")]
        public List<ConfigurationFeaturesSubscriptionUpdateProductOptions> Products
        {
            get => this.products;
            set
            {
                this.products = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Determines how to handle prorations resulting from subscription updates. Valid values
        /// are <c>none</c>, <c>create_prorations</c>, and <c>always_invoice</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Setting to control when an update should be scheduled at the end of the period instead
        /// of applying immediately.
        /// </summary>
        [JsonProperty("schedule_at_period_end")]
        [STJS.JsonPropertyName("schedule_at_period_end")]
        public ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndOptions ScheduleAtPeriodEnd { get; set; }

        /// <summary>
        /// The behavior when updating a subscription that is trialing.
        /// One of: <c>continue_trial</c>, or <c>end_trial</c>.
        /// </summary>
        [JsonProperty("trial_update_behavior")]
        [STJS.JsonPropertyName("trial_update_behavior")]
        public string TrialUpdateBehavior { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
