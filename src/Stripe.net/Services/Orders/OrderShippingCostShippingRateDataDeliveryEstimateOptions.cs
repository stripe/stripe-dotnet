// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderShippingCostShippingRateDataDeliveryEstimateOptions : INestedOptions
    {
        /// <summary>
        /// The upper bound of the estimated range. If empty, represents no upper bound i.e.,
        /// infinite.
        /// </summary>
        [JsonProperty("maximum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum")]
#endif
        public OrderShippingCostShippingRateDataDeliveryEstimateMaximumOptions Maximum { get; set; }

        /// <summary>
        /// The lower bound of the estimated range. If empty, represents no lower bound.
        /// </summary>
        [JsonProperty("minimum")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum")]
#endif
        public OrderShippingCostShippingRateDataDeliveryEstimateMinimumOptions Minimum { get; set; }
    }
}
