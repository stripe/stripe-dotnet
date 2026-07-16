// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePauseSchedule : StripeEntity<SubscriptionSchedulePauseSchedule>
    {
        /// <summary>
        /// A unique identifier for this pause schedule.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonProperty("pause")]
        [STJS.JsonPropertyName("pause")]
        public SubscriptionSchedulePauseSchedulePause Pause { get; set; }

        /// <summary>
        /// Details about when and how the subscription resumes.
        /// </summary>
        [JsonProperty("resume")]
        [STJS.JsonPropertyName("resume")]
        public SubscriptionSchedulePauseScheduleResume Resume { get; set; }
    }
}
