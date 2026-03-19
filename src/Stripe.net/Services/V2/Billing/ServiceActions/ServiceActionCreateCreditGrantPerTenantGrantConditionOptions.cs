// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ServiceActionCreateCreditGrantPerTenantGrantConditionOptions : INestedOptions
    {
        /// <summary>
        /// The type of the grant condition. We currently support
        /// <c>meter_event_first_per_period</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The grant condition for the meter event first per period.
        /// </summary>
        [JsonProperty("meter_event_first_per_period")]
        [STJS.JsonPropertyName("meter_event_first_per_period")]
        public ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodOptions MeterEventFirstPerPeriod { get; set; }
    }
}
