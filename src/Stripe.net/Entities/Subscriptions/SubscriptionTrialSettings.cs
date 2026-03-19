// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionTrialSettings : StripeEntity<SubscriptionTrialSettings>
    {
        /// <summary>
        /// Defines how a subscription behaves when a trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public SubscriptionTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
