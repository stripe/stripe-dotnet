// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverride : StripeEntity<RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverride>
    {
        /// <summary>
        /// The digital fulfillment option.
        /// </summary>
        [JsonProperty("digital")]
        [STJS.JsonPropertyName("digital")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideDigital Digital { get; set; }

        /// <summary>
        /// The line items this fulfillment option applies to.
        /// </summary>
        [JsonProperty("line_item_keys")]
        [STJS.JsonPropertyName("line_item_keys")]
        public List<string> LineItemKeys { get; set; }

        /// <summary>
        /// The shipping option.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideShipping Shipping { get; set; }

        /// <summary>
        /// The type of the selected fulfillment option.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
