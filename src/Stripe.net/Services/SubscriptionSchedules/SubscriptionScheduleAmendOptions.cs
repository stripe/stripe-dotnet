// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendOptions : BaseOptions
    {
        /// <summary>
        /// Changes to apply to the phases of the subscription schedule, in the order provided.
        /// </summary>
        [JsonProperty("amendments")]
        public List<SubscriptionScheduleAmendmentOptions> Amendments { get; set; }

        /// <summary>
        /// Changes to apply to the subscription schedule.
        /// </summary>
        [JsonProperty("schedule_settings")]
        public SubscriptionScheduleScheduleSettingsOptions ScheduleSettings { get; set; }
    }
}
