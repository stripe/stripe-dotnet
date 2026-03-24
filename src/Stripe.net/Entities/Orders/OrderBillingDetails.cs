// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderBillingDetails : StripeEntity<OrderBillingDetails>
    {
        /// <summary>
        /// Billing address for the order.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Email address for the order.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Full name for the order.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Billing phone number for the order (including extension).
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
