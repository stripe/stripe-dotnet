// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the shipping rate to use for this order.
        /// </summary>
        [JsonProperty("shipping_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_rate")]
#endif
        public string ShippingRate { get; set; }

        /// <summary>
        /// Parameters to create a new ad-hoc shipping rate for this order.
        /// </summary>
        [JsonProperty("shipping_rate_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_rate_data")]
#endif
        public OrderShippingCostShippingRateDataOptions ShippingRateData { get; set; }
    }
}
