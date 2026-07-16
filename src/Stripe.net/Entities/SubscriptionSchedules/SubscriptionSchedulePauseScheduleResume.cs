// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePauseScheduleResume : StripeEntity<SubscriptionSchedulePauseScheduleResume>
    {
        /// <summary>
        /// Time at which the subscription resumes.
        /// </summary>
        [JsonProperty("resume_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("resume_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ResumeAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public SubscriptionSchedulePauseScheduleResumeSettings Settings { get; set; }
    }
}
