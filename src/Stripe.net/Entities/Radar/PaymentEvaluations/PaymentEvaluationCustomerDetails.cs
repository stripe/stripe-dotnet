// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationCustomerDetails : StripeEntity<PaymentEvaluationCustomerDetails>
    {
        /// <summary>
        /// The ID of the customer associated with the payment evaluation.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the Account representing the customer associated with the payment evaluation.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The customer's full name or business name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }
    }
}
