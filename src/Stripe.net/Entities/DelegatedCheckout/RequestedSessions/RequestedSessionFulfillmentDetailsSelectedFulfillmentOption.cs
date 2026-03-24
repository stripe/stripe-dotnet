// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOption : StripeEntity<RequestedSessionFulfillmentDetailsSelectedFulfillmentOption>
    {
        /// <summary>
        /// The shipping option.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionShipping Shipping { get; set; }

        /// <summary>
        /// The type of the selected fulfillment option.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The digital fulfillment option.
        /// </summary>
        [JsonProperty("digital")]
        [STJS.JsonPropertyName("digital")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionDigital Digital { get; set; }
    }
}
