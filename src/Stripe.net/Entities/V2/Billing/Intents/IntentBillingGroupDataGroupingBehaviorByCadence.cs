// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentBillingGroupDataGroupingBehaviorByCadence : StripeEntity<IntentBillingGroupDataGroupingBehaviorByCadence>
    {
        /// <summary>
        /// Timestamp that anchors the recurring grouping cadence.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public DateTime? BillingCycleAnchor { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Daily cadence details.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public IntentBillingGroupDataGroupingBehaviorByCadenceDay Day { get; set; }

        /// <summary>
        /// The number of interval units between groups.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long IntervalCount { get; set; }

        /// <summary>
        /// Monthly cadence details.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public IntentBillingGroupDataGroupingBehaviorByCadenceMonth Month { get; set; }

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
        public IntentBillingGroupDataGroupingBehaviorByCadenceWeek Week { get; set; }

        /// <summary>
        /// Yearly cadence details.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public IntentBillingGroupDataGroupingBehaviorByCadenceYear Year { get; set; }
    }
}
