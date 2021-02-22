// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionCancelOptions : INestedOptions
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether to cancel subscriptions immediately or at the end of the billing period.
        /// One of: <c>at_period_end</c>, or <c>immediately</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Whether to create prorations when canceling subscriptions. Possible values are
        /// <c>none</c> and <c>create_prorations</c>, which is only compatible with
        /// <c>mode=immediately</c>. No prorations are generated when canceling a subscription at
        /// the end of its natural billing period.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
