// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionShippingOptions : INestedOptions
    {
        /// <summary>
        /// The shipping option identifer.
        /// </summary>
        [JsonProperty("shipping_option")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_option")]
#endif
        public string ShippingOption { get; set; }
    }
}
