// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsFulfillmentOption : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOption>
    {
        /// <summary>
        /// The shipping option.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public RequestedSessionFulfillmentDetailsFulfillmentOptionShipping Shipping { get; set; }

        /// <summary>
        /// The type of the fulfillment option.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
