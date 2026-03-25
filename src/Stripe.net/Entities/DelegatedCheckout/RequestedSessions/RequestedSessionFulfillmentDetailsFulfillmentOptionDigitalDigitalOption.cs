// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsFulfillmentOptionDigitalDigitalOption : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionDigitalDigitalOption>
    {
        /// <summary>
        /// The description of the digital fulfillment option.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The digital amount of the digital fulfillment option.
        /// </summary>
        [JsonProperty("digital_amount")]
        [STJS.JsonPropertyName("digital_amount")]
        public long DigitalAmount { get; set; }

        /// <summary>
        /// The display name of the digital fulfillment option.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The key of the digital fulfillment option.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// The line item keys associated with this digital fulfillment option.
        /// </summary>
        [JsonProperty("line_item_keys")]
        [STJS.JsonPropertyName("line_item_keys")]
        public List<string> LineItemKeys { get; set; }
    }
}
