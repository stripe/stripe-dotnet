// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesSubscriptionCancelOptions : INestedOptions
    {
        /// <summary>
        /// Whether the cancellation reasons will be collected in the portal and which options are
        /// exposed to the customer.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif
        public ConfigurationFeaturesSubscriptionCancelCancellationReasonOptions CancellationReason { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether to cancel subscriptions immediately or at the end of the billing period.
        /// One of: <c>at_period_end</c>, or <c>immediately</c>.
        /// </summary>
        [JsonProperty("mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mode")]
#endif
        public string Mode { get; set; }

        /// <summary>
        /// Whether to create prorations when canceling subscriptions. Possible values are
        /// <c>none</c> and <c>create_prorations</c>, which is only compatible with
        /// <c>mode=immediately</c>. Passing <c>always_invoice</c> will result in an error. No
        /// prorations are generated when canceling a subscription at the end of its natural billing
        /// period.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }
    }
}
