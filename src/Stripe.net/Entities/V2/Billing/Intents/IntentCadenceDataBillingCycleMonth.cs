// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentCadenceDataBillingCycleMonth : StripeEntity<IntentCadenceDataBillingCycleMonth>
    {
        /// <summary>
        /// The day to anchor the billing on for a type="month" billing cycle from 1-31. If this
        /// number is greater than the number of days in the month being billed, this anchors to the
        /// last day of the month.
        /// </summary>
        [JsonProperty("day_of_month")]
        [STJS.JsonPropertyName("day_of_month")]
        public long DayOfMonth { get; set; }

        /// <summary>
        /// The month to anchor the billing on for a type="month" billing cycle from 1-12.
        /// Occurrences are calculated from the month anchor.
        /// </summary>
        [JsonProperty("month_of_year")]
        [STJS.JsonPropertyName("month_of_year")]
        public long? MonthOfYear { get; set; }

        /// <summary>
        /// The time at which the billing cycle ends.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentCadenceDataBillingCycleMonthTime Time { get; set; }
    }
}
