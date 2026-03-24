// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateCadenceDataBillingCycleWeekOptions : INestedOptions
    {
        /// <summary>
        /// The day of the week to bill the type=week billing cycle on. Numbered from 1-7 for Monday
        /// to Sunday respectively, based on the ISO-8601 week day numbering. If not provided, this
        /// will default to the day the cadence was created.
        /// </summary>
        [JsonProperty("day_of_week")]
        [STJS.JsonPropertyName("day_of_week")]
        public long? DayOfWeek { get; set; }

        /// <summary>
        /// The time at which the billing cycle ends. This field is optional, and if not provided,
        /// it will default to the time at which the cadence was created in UTC timezone.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentCreateCadenceDataBillingCycleWeekTimeOptions Time { get; set; }
    }
}
