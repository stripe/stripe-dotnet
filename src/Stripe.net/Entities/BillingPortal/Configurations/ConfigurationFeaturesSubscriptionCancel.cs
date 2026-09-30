// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesSubscriptionCancel : StripeEntity<ConfigurationFeaturesSubscriptionCancel>
    {
        [JsonProperty("cancellation_reason")]
        [STJS.JsonPropertyName("cancellation_reason")]
        public ConfigurationFeaturesSubscriptionCancelCancellationReason CancellationReason { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether to cancel subscriptions immediately or at the end of the billing period.
        /// One of: <c>at_period_end</c>, or <c>immediately</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Whether to create prorations when canceling subscriptions. Possible values are
        /// <c>none</c> and <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
