// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOptions : INestedOptions
    {
        /// <summary>
        /// The shipping fulfillment option.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionShippingOptions Shipping { get; set; }

        /// <summary>
        /// The type of fulfillment option.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
