// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateCadenceDataBillingCycleYearOptions : INestedOptions
    {
        /// <summary>
        /// The day to anchor the billing on for a type="month" billing cycle from 1-31. If this
        /// number is greater than the number of days in the month being billed, this will anchor to
        /// the last day of the month. If not provided, this will default to the day the cadence was
        /// created.
        /// </summary>
        [JsonProperty("day_of_month")]
        [STJS.JsonPropertyName("day_of_month")]
        public long? DayOfMonth { get; set; }

        /// <summary>
        /// The month to bill on from 1-12. If not provided, this will default to the month the
        /// cadence was created.
        /// </summary>
        [JsonProperty("month_of_year")]
        [STJS.JsonPropertyName("month_of_year")]
        public long? MonthOfYear { get; set; }

        /// <summary>
        /// The time at which the billing cycle ends. This field is optional, and if not provided,
        /// it will default to the time at which the cadence was created in UTC timezone.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentCreateCadenceDataBillingCycleYearTimeOptions Time { get; set; }
    }
}
