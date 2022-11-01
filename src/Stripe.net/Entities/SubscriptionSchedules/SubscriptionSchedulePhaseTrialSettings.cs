// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseTrialSettings : StripeEntity<SubscriptionSchedulePhaseTrialSettings>
    {
        /// <summary>
        /// Defines how the subscription should behaves when a trial ensd.
        /// </summary>
        [JsonProperty("end_behavior")]
        public SubscriptionSchedulePhaseTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
