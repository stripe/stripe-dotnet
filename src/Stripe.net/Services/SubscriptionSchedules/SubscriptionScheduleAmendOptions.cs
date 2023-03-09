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
        /// Provide any time periods to bill in advance.
        /// </summary>
        [JsonProperty("prebilling")]
        public List<SubscriptionSchedulePrebillingOptions> Prebilling { get; set; }

        /// <summary>
        /// In cases where the amendment changes the currently active phase, specifies if and how to
        /// prorate at the time of the request.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Changes to apply to the subscription schedule.
        /// </summary>
        [JsonProperty("schedule_settings")]
        public SubscriptionScheduleScheduleSettingsOptions ScheduleSettings { get; set; }
    }
}
