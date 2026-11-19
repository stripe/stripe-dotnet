// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GroupCreateGroupingBehaviorByCadenceOptions : INestedOptions
    {
        /// <summary>
        /// Timestamp that anchors the recurring grouping cadence.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// Daily cadence details.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public GroupCreateGroupingBehaviorByCadenceDayOptions Day { get; set; }

        /// <summary>
        /// The number of interval units between groups. Defaults to 1.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Monthly cadence details.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public GroupCreateGroupingBehaviorByCadenceMonthOptions Month { get; set; }

        /// <summary>
        /// The interval unit for the cadence.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Weekly cadence details.
        /// </summary>
        [JsonProperty("week")]
        [STJS.JsonPropertyName("week")]
        public GroupCreateGroupingBehaviorByCadenceWeekOptions Week { get; set; }

        /// <summary>
        /// Yearly cadence details.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public GroupCreateGroupingBehaviorByCadenceYearOptions Year { get; set; }
    }
}
