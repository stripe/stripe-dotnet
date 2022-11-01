// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentAmendmentEndOptions : INestedOptions
    {
        /// <summary>
        /// Use the <c>end</c> time of a given discount.
        /// </summary>
        [JsonProperty("discount_end")]
        public SubscriptionScheduleAmendmentAmendmentEndDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// Time span for the amendment starting from the <c>amendment_start</c>.
        /// </summary>
        [JsonProperty("duration")]
        public SubscriptionScheduleAmendmentAmendmentEndDurationOptions Duration { get; set; }

        /// <summary>
        /// A precise Unix timestamp for the amendment to end. Must be after the
        /// <c>amendment_start</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Select one of three ways to pass the <c>amendment_end</c>.
        /// One of: <c>discount_end</c>, <c>duration</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
