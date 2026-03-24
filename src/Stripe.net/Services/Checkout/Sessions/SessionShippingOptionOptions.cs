// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionShippingOptionOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Shipping Rate to use for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate")]
        [STJS.JsonPropertyName("shipping_rate")]
        public string ShippingRate { get; set; }

        /// <summary>
        /// Parameters to be passed to Shipping Rate creation for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate_data")]
        [STJS.JsonPropertyName("shipping_rate_data")]
        public SessionShippingOptionShippingRateDataOptions ShippingRateData { get; set; }
    }
}
