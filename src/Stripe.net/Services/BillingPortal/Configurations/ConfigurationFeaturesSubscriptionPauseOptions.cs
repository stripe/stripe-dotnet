// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesSubscriptionPauseOptions : INestedOptions
    {
        /// <summary>
        /// Controls how long a subscription can be paused. Defaults to <c>interval_options</c> with
        /// a single one-month option.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public ConfigurationFeaturesSubscriptionPauseDurationOptions Duration { get; set; }

        /// <summary>
        /// Whether the feature is enabled. Customers can only pause subscriptions in the <a
        /// href="https://stripe.com/customer-management">redesigned customer portal</a>.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
