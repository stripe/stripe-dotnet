// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentCadenceDataBillingCycleWeek : StripeEntity<IntentCadenceDataBillingCycleWeek>
    {
        /// <summary>
        /// The day of the week to bill the type=week billing cycle on. Numbered from 1-7 for Monday
        /// to Sunday respectively, based on the ISO-8601 week day numbering.
        /// </summary>
        [JsonProperty("day_of_week")]
        [STJS.JsonPropertyName("day_of_week")]
        public long DayOfWeek { get; set; }

        /// <summary>
        /// The time at which the billing cycle ends.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentCadenceDataBillingCycleWeekTime Time { get; set; }
    }
}
