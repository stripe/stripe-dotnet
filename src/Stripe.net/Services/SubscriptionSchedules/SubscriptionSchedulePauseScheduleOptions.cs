// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseScheduleOptions : INestedOptions
    {
        /// <summary>
        /// A unique identifier for this pause schedule entry.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Configuration for when and how the subscription pauses.
        /// </summary>
        [JsonProperty("pause")]
        [STJS.JsonPropertyName("pause")]
        public SubscriptionSchedulePauseSchedulePauseOptions Pause { get; set; }

        /// <summary>
        /// Configuration for when and how the subscription resumes.
        /// </summary>
        [JsonProperty("resume")]
        [STJS.JsonPropertyName("resume")]
        public SubscriptionSchedulePauseScheduleResumeOptions Resume { get; set; }
    }
}
