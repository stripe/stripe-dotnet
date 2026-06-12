// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsMoneyServicesBeneficiaryDetailsOptions : INestedOptions
    {
        /// <summary>
        /// An opaque identifier for the beneficiary's account (e.g. bank account number, card
        /// first6+last4, or other unique identifier).
        /// </summary>
        [JsonProperty("account_reference")]
        [STJS.JsonPropertyName("account_reference")]
        public string AccountReference { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonProperty("date_of_birth")]
        [STJS.JsonPropertyName("date_of_birth")]
        public PaymentIntentPaymentDetailsMoneyServicesBeneficiaryDetailsDateOfBirthOptions DateOfBirth { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Given (first) name.
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
        /// Surname (family name).
        /// </summary>
        [JsonProperty("surname")]
        [STJS.JsonPropertyName("surname")]
        public string Surname { get; set; }
    }
}
