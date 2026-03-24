// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitInitiatingPaymentMethodDetailsBillingDetails : StripeEntity<ReceivedDebitInitiatingPaymentMethodDetailsBillingDetails>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Full name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
