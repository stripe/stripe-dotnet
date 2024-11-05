// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesScheduleDetailsPhaseTrialSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Defines how the subscription should behave when a trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        public InvoiceUpcomingLinesScheduleDetailsPhaseTrialSettingsEndBehaviorOptions EndBehavior { get; set; }
    }
}