// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseScheduleResumeOptions : INestedOptions
    {
        /// <summary>
        /// When to resume the subscription.
        /// </summary>
        [JsonProperty("resume_at")]
        [STJS.JsonPropertyName("resume_at")]
        public SubscriptionSchedulePauseScheduleResumeResumeAtOptions ResumeAt { get; set; }

        /// <summary>
        /// Settings controlling how the subscription resumes.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public SubscriptionSchedulePauseScheduleResumeSettingsOptions Settings { get; set; }
    }
}
