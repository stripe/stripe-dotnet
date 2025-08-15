// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionDimensionOptions : INestedOptions
    {
        /// <summary>
        /// The payload key for the dimension.
        /// </summary>
        [JsonProperty("payload_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payload_key")]
#endif
        public string PayloadKey { get; set; }

        /// <summary>
        /// The value for the dimension.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
