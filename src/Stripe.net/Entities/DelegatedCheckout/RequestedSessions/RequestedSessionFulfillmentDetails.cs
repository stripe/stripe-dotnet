// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetails : StripeEntity<RequestedSessionFulfillmentDetails>
    {
        /// <summary>
        /// The fulfillment address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public RequestedSessionFulfillmentDetailsAddress Address { get; set; }

        /// <summary>
        /// The email address for the fulfillment details.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The fulfillment options.
        /// </summary>
        [JsonProperty("fulfillment_options")]
        [STJS.JsonPropertyName("fulfillment_options")]
        public List<RequestedSessionFulfillmentDetailsFulfillmentOption> FulfillmentOptions { get; set; }

        /// <summary>
        /// The name for the fulfillment details.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number for the fulfillment details.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The fulfillment option.
        /// </summary>
        [JsonProperty("selected_fulfillment_option")]
        [STJS.JsonPropertyName("selected_fulfillment_option")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOption SelectedFulfillmentOption { get; set; }
    }
}
