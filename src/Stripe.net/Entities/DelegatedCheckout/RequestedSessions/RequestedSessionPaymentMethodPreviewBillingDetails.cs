// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionPaymentMethodPreviewBillingDetails : StripeEntity<RequestedSessionPaymentMethodPreviewBillingDetails>
    {
        /// <summary>
        /// The billing address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public RequestedSessionPaymentMethodPreviewBillingDetailsAddress Address { get; set; }

        /// <summary>
        /// The email address for the billing details.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The name for the billing details.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number for the billing details.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
