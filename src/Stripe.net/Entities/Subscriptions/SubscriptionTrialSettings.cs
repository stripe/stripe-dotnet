// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionTrialSettings : StripeEntity<SubscriptionTrialSettings>
    {
        /// <summary>
        /// Defines how a subscription behaves when a free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        public SubscriptionTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
