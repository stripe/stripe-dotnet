// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleAmendOptions : BaseOptions
    {
        /// <summary>
        /// Changes to apply to the phases of the subscription schedule, in the order provided.
        /// </summary>
        [JsonProperty("amendments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amendments")]
#endif
        public List<SubscriptionScheduleAmendmentOptions> Amendments { get; set; }

        /// <summary>
        /// Provide any time periods to bill in advance.
        /// </summary>
        [JsonProperty("prebilling")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prebilling")]
#endif
        public List<SubscriptionSchedulePrebillingOptions> Prebilling { get; set; }

        /// <summary>
        /// In cases where the amendment changes the currently active phase, specifies if and how to
        /// prorate at the time of the request.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Changes to apply to the subscription schedule.
        /// </summary>
        [JsonProperty("schedule_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule_settings")]
#endif
        public SubscriptionScheduleScheduleSettingsOptions ScheduleSettings { get; set; }
    }
}
