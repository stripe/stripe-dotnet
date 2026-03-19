// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionFulfillmentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer's address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The customer's name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The fulfillment option to select.
        /// </summary>
        [JsonProperty("selected_fulfillment_option")]
        [STJS.JsonPropertyName("selected_fulfillment_option")]
        public RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOptions SelectedFulfillmentOption { get; set; }

        /// <summary>
        /// The fulfillment option overrides for specific line items.
        /// </summary>
        [JsonProperty("selected_fulfillment_option_overrides")]
        [STJS.JsonPropertyName("selected_fulfillment_option_overrides")]
        public List<RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOverrideOptions> SelectedFulfillmentOptionOverrides { get; set; }
    }
}
