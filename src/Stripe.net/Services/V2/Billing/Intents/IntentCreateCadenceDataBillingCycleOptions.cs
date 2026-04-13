// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateCadenceDataBillingCycleOptions : INestedOptions
    {
        /// <summary>
        /// Specific configuration for determining billing dates when type=day.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public IntentCreateCadenceDataBillingCycleDayOptions Day { get; set; }

        /// <summary>
        /// The number of intervals (specified in the interval attribute) between cadence billings.
        /// For example, type=month and interval_count=3 bills every 3 months. If this is not
        /// provided, it will default to 1.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Specific configuration for determining billing dates when type=month.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public IntentCreateCadenceDataBillingCycleMonthOptions Month { get; set; }

        /// <summary>
        /// The frequency at which a cadence bills.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Specific configuration for determining billing dates when type=week.
        /// </summary>
        [JsonProperty("week")]
        [STJS.JsonPropertyName("week")]
        public IntentCreateCadenceDataBillingCycleWeekOptions Week { get; set; }

        /// <summary>
        /// Specific configuration for determining billing dates when type=year.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public IntentCreateCadenceDataBillingCycleYearOptions Year { get; set; }
    }
}
