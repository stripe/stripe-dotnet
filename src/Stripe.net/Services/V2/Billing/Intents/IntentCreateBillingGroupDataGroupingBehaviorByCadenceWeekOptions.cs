// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateBillingGroupDataGroupingBehaviorByCadenceWeekOptions : INestedOptions
    {
        /// <summary>
        /// The ISO-8601 day of week, from 1 for Monday through 7 for Sunday.
        /// </summary>
        [JsonProperty("day_of_week")]
        [STJS.JsonPropertyName("day_of_week")]
        public long? DayOfWeek { get; set; }

        /// <summary>
        /// The time at which the weekly grouping interval begins. Defaults to the time the billing
        /// group is created, in UTC.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentCreateBillingGroupDataGroupingBehaviorByCadenceWeekTimeOptions Time { get; set; }
    }
}
