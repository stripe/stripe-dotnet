// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionOptions : INestedOptions
    {
        /// <summary>
        /// The type of the meter segment condition. We currently support <c>dimension</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Dimension-based meter segment condition.
        /// </summary>
        [JsonProperty("dimension")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dimension")]
#endif
        public ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionDimensionOptions Dimension { get; set; }
    }
}
