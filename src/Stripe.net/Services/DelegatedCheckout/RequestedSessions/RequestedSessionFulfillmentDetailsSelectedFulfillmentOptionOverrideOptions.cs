// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideOptions : INestedOptions
    {
        /// <summary>
        /// The digital fulfillment option.
        /// </summary>
        [JsonProperty("digital")]
        [STJS.JsonPropertyName("digital")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideDigitalOptions Digital { get; set; }

        /// <summary>
        /// The line item keys that this fulfillment option override applies to.
        /// </summary>
        [JsonProperty("line_item_keys")]
        [STJS.JsonPropertyName("line_item_keys")]
        public List<string> LineItemKeys { get; set; }

        /// <summary>
        /// The shipping fulfillment option.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideShippingOptions Shipping { get; set; }

        /// <summary>
        /// The type of fulfillment option.
        /// One of: <c>digital</c>, or <c>shipping</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
