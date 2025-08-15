// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodOptions : INestedOptions
    {
        /// <summary>
        /// The meter segment conditions for the grant condition.
        /// </summary>
        [JsonProperty("meter_segment_conditions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter_segment_conditions")]
#endif
        public List<ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionOptions> MeterSegmentConditions { get; set; }
    }
}
