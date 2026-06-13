// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetails : StripeEntity<PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetails>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsAddress Address { get; set; }

        [JsonProperty("date_of_birth")]
        [STJS.JsonPropertyName("date_of_birth")]
        public PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsDateOfBirth DateOfBirth { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Given name (first name).
        /// </summary>
        [JsonProperty("given_name")]
        [STJS.JsonPropertyName("given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Surname (last name).
        /// </summary>
        [JsonProperty("surname")]
        [STJS.JsonPropertyName("surname")]
        public string Surname { get; set; }
    }
}
