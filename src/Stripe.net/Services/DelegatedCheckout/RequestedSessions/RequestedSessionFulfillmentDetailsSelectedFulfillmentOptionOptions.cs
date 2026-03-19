// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOptions : INestedOptions
    {
        /// <summary>
        /// The shipping fulfillment option.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionShippingOptions Shipping { get; set; }

        /// <summary>
        /// The type of fulfillment option.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The digital fulfillment option.
        /// </summary>
        [JsonProperty("digital")]
        [STJS.JsonPropertyName("digital")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionDigitalOptions Digital { get; set; }
    }
}
