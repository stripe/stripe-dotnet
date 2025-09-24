// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceBillingCycle : StripeEntity<CadenceBillingCycle>
    {
        /// <summary>
        /// The number of intervals (specified in the interval attribute) between cadence billings.
        /// For example, type=month and interval_count=3 bills every 3 months.
        /// </summary>
        [JsonProperty("interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_count")]
#endif
        public long IntervalCount { get; set; }

        /// <summary>
        /// The frequency at which a cadence bills.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Specific configuration for determining billing dates when type=day.
        /// </summary>
        [JsonProperty("day")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("day")]
#endif
        public CadenceBillingCycleDay Day { get; set; }

        /// <summary>
        /// Specific configuration for determining billing dates when type=month.
        /// </summary>
        [JsonProperty("month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("month")]
#endif
        public CadenceBillingCycleMonth Month { get; set; }

        /// <summary>
        /// Specific configuration for determining billing dates when type=week.
        /// </summary>
        [JsonProperty("week")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("week")]
#endif
        public CadenceBillingCycleWeek Week { get; set; }

        /// <summary>
        /// Specific configuration for determining billing dates when type=year.
        /// </summary>
        [JsonProperty("year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("year")]
#endif
        public CadenceBillingCycleYear Year { get; set; }
    }
}
