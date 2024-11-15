// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceShippingCostShippingRateDataDeliveryEstimateMaximumOptions : INestedOptions
    {
        /// <summary>
        /// A unit of time.
        /// One of: <c>business_day</c>, <c>day</c>, <c>hour</c>, <c>month</c>, or <c>week</c>.
        /// </summary>
        [JsonProperty("unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit")]
#endif

        public string Unit { get; set; }

        /// <summary>
        /// Must be greater than 0.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif

        public long? Value { get; set; }
    }
}
