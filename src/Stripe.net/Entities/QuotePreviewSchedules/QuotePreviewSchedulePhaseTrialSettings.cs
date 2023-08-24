// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePreviewSchedulePhaseTrialSettings : StripeEntity<QuotePreviewSchedulePhaseTrialSettings>
    {
        /// <summary>
        /// Defines how the subscription should behaves when a trial ensd.
        /// </summary>
        [JsonProperty("end_behavior")]
        public QuotePreviewSchedulePhaseTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
