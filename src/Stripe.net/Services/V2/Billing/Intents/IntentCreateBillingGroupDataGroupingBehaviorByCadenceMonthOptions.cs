// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateBillingGroupDataGroupingBehaviorByCadenceMonthOptions : INestedOptions
    {
        /// <summary>
        /// The day of month, from 1 through 31. For shorter months, the cadence anchors to the
        /// month's last day.
        /// </summary>
        [JsonProperty("day_of_month")]
        [STJS.JsonPropertyName("day_of_month")]
        public long? DayOfMonth { get; set; }

        /// <summary>
        /// The month of year, from 1 through 12, from which occurrences are calculated. Defaults to
        /// the month when the billing group was created.
        /// </summary>
        [JsonProperty("month_of_year")]
        [STJS.JsonPropertyName("month_of_year")]
        public long? MonthOfYear { get; set; }

        /// <summary>
        /// The time at which the monthly grouping interval begins. Defaults to the time the billing
        /// group is created, in UTC.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentCreateBillingGroupDataGroupingBehaviorByCadenceMonthTimeOptions Time { get; set; }
    }
}
