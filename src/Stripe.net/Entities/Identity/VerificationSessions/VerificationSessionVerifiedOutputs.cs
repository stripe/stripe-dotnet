// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationSessionVerifiedOutputs : StripeEntity<VerificationSessionVerifiedOutputs>
    {
        /// <summary>
        /// The user's verified address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The user’s verified date of birth.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public VerificationSessionVerifiedOutputsDob Dob { get; set; }

        /// <summary>
        /// The user's verified email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The user's verified first name.
        /// </summary>
        [JsonProperty("first_name")]
        [STJS.JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The user's verified id number.
        /// </summary>
        [JsonProperty("id_number")]
        [STJS.JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// The user's verified id number type.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonProperty("id_number_type")]
        [STJS.JsonPropertyName("id_number_type")]
        public string IdNumberType { get; set; }

        /// <summary>
        /// The user's verified last name.
        /// </summary>
        [JsonProperty("last_name")]
        [STJS.JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The user's verified phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The user's verified sex.
        /// One of: <c>[redacted]</c>, <c>female</c>, <c>male</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("sex")]
        [STJS.JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// The user's verified place of birth as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_place_of_birth")]
        [STJS.JsonPropertyName("unparsed_place_of_birth")]
        public string UnparsedPlaceOfBirth { get; set; }

        /// <summary>
        /// The user's verified sex as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_sex")]
        [STJS.JsonPropertyName("unparsed_sex")]
        public string UnparsedSex { get; set; }
    }
}
