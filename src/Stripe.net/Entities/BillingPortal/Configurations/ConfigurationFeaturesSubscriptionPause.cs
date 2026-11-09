// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesSubscriptionPause : StripeEntity<ConfigurationFeaturesSubscriptionPause>
    {
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public ConfigurationFeaturesSubscriptionPauseDuration Duration { get; set; }

        /// <summary>
        /// Whether the feature is enabled. Customers can only pause subscriptions in the <a
        /// href="https://stripe.com/customer-management">redesigned customer portal</a>.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
