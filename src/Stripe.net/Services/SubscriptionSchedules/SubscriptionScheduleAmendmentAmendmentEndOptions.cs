// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentAmendmentEndOptions : INestedOptions
    {
        /// <summary>
        /// Time span for the amendment starting from the <c>amendment_start</c>.
        /// </summary>
        [JsonProperty("duration")]
        public SubscriptionScheduleAmendmentAmendmentEndDurationOptions Duration { get; set; }

        /// <summary>
        /// Cover all remaining phases of the subscription schedule with the amendment.
        /// </summary>
        [JsonProperty("schedule_end")]
        public SubscriptionScheduleAmendmentAmendmentEndScheduleEndOptions ScheduleEnd { get; set; }

        /// <summary>
        /// A precise Unix timestamp for the amendment to end. Must be after the
        /// <c>amendment_start</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        public SubscriptionScheduleAmendmentAmendmentEndTimestampOptions Timestamp { get; set; }

        /// <summary>
        /// Select one of three ways to pass the <c>amendment_end</c>.
        /// One of: <c>duration</c>, <c>schedule_end</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
