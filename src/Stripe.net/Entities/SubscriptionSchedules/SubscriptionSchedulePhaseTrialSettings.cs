// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseTrialSettings : StripeEntity<SubscriptionSchedulePhaseTrialSettings>
    {
        /// <summary>
        /// Defines how the subscription should behave when a trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        public SubscriptionSchedulePhaseTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
