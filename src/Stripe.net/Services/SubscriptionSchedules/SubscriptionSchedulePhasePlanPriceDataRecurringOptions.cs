namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SubscriptionSchedulePhasePlanPriceDataRecurringOptions : INestedOptions
    {
        /// <summary>
        /// Specifies billing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between subscription billings. For example,
        /// <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of one
        /// year interval allowed (1 year, 12 months, or 52 weeks).
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
