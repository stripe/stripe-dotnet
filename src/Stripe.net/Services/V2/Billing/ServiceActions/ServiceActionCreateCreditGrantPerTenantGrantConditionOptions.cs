// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreateCreditGrantPerTenantGrantConditionOptions : INestedOptions
    {
        /// <summary>
        /// The type of the grant condition. We currently support
        /// <c>meter_event_first_per_period</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The grant condition for the meter event first per period.
        /// </summary>
        [JsonProperty("meter_event_first_per_period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter_event_first_per_period")]
#endif
        public ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodOptions MeterEventFirstPerPeriod { get; set; }
    }
}
