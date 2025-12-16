// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetails : StripeEntity<RequestedSessionFulfillmentDetails>
    {
        /// <summary>
        /// The fulfillment address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public RequestedSessionFulfillmentDetailsAddress Address { get; set; }

        /// <summary>
        /// The email address for the fulfillment details.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The fulfillment options.
        /// </summary>
        [JsonProperty("fulfillment_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fulfillment_options")]
#endif
        public List<RequestedSessionFulfillmentDetailsFulfillmentOption> FulfillmentOptions { get; set; }

        /// <summary>
        /// The name for the fulfillment details.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The phone number for the fulfillment details.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The fulfillment option.
        /// </summary>
        [JsonProperty("selected_fulfillment_option")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("selected_fulfillment_option")]
#endif
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOption SelectedFulfillmentOption { get; set; }
    }
}
