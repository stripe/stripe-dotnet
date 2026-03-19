// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionDimensionOptions : INestedOptions
    {
        /// <summary>
        /// The payload key for the dimension.
        /// </summary>
        [JsonProperty("payload_key")]
        [STJS.JsonPropertyName("payload_key")]
        public string PayloadKey { get; set; }

        /// <summary>
        /// The value for the dimension.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
