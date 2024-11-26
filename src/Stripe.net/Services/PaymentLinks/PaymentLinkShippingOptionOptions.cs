// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkShippingOptionOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Shipping Rate to use for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_rate")]
#endif
        public string ShippingRate { get; set; }
    }
}
