// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionPaymentMethodDataBillingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The address for the billing details.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The email for the billing details.
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
        /// The phone for the billing details.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
