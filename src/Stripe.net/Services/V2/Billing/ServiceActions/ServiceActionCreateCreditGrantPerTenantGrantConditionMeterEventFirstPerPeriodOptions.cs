// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodOptions : INestedOptions
    {
        /// <summary>
        /// The meter segment conditions for the grant condition.
        /// </summary>
        [JsonProperty("meter_segment_conditions")]
        [STJS.JsonPropertyName("meter_segment_conditions")]
        public List<ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionOptions> MeterSegmentConditions { get; set; }
    }
}
