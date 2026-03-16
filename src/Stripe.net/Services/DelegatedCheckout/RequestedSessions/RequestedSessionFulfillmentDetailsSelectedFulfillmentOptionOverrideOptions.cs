// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideOptions : INestedOptions
    {
        /// <summary>
        /// The digital fulfillment option.
        /// </summary>
        [JsonProperty("digital")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("digital")]
#endif
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideDigitalOptions Digital { get; set; }

        /// <summary>
        /// The line item keys that this fulfillment option override applies to.
        /// </summary>
        [JsonProperty("line_item_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_item_keys")]
#endif
        public List<string> LineItemKeys { get; set; }

        /// <summary>
        /// The shipping fulfillment option.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideShippingOptions Shipping { get; set; }

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
