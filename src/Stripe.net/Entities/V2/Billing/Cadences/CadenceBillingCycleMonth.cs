// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceBillingCycleMonth : StripeEntity<CadenceBillingCycleMonth>
    {
        /// <summary>
        /// The day to anchor the billing on for a type="month" billing cycle from 1-31. If this
        /// number is greater than the number of days in the month being billed, this will anchor to
        /// the last day of the month.
        /// </summary>
        [JsonProperty("day_of_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("day_of_month")]
#endif
        public long DayOfMonth { get; set; }

        /// <summary>
        /// The time at which the billing cycle ends.
        /// </summary>
        [JsonProperty("time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time")]
#endif
        public CadenceBillingCycleMonthTime Time { get; set; }
    }
}
