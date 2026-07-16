// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseScheduleResumeResumeAtOptions : INestedOptions
    {
        /// <summary>
        /// The duration after which to resume the subscription. Required when <c>type</c> is
        /// <c>duration</c>.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public SubscriptionSchedulePauseScheduleResumeResumeAtDurationOptions Duration { get; set; }

        /// <summary>
        /// The Unix timestamp at which to resume the subscription. Required when <c>type</c> is
        /// <c>timestamp</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// When to resume the subscription. Use <c>now</c> to resume immediately, <c>duration</c>
        /// to resume after a set duration, or <c>timestamp</c> to resume at a specific time.
        /// One of: <c>duration</c>, <c>now</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
