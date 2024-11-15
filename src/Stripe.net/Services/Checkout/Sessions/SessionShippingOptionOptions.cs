// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionShippingOptionOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Shipping Rate to use for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_rate")]
#endif

        public string ShippingRate { get; set; }

        /// <summary>
        /// Parameters to be passed to Shipping Rate creation for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_rate_data")]
#endif

        public SessionShippingOptionShippingRateDataOptions ShippingRateData { get; set; }
    }
}
