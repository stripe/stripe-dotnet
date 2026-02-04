// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateCadenceDataBillingCycleMonthOptions : INestedOptions
    {
        /// <summary>
        /// The day to anchor the billing on for a type="month" billing cycle from 1-31. If this
        /// number is greater than the number of days in the month being billed, this will anchor to
        /// the last day of the month. If not provided, this will default to the day the cadence was
        /// created.
        /// </summary>
        [JsonProperty("day_of_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("day_of_month")]
#endif
        public long? DayOfMonth { get; set; }

        /// <summary>
        /// The month to anchor the billing on for a type="month" billing cycle from 1-12. If not
        /// provided, this will default to the month the cadence was created. This setting can only
        /// be used for monthly billing cycles with <c>interval_count</c> of 2, 3, 4 or 6. All
        /// occurrences will be calculated from month provided.
        /// </summary>
        [JsonProperty("month_of_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("month_of_year")]
#endif
        public long? MonthOfYear { get; set; }

        /// <summary>
        /// The time at which the billing cycle ends. This field is optional, and if not provided,
        /// it will default to the time at which the cadence was created in UTC timezone.
        /// </summary>
        [JsonProperty("time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time")]
#endif
        public IntentCreateCadenceDataBillingCycleMonthTimeOptions Time { get; set; }
    }
}
