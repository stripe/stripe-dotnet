// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionVerifiedOutputs : StripeEntity<VerificationSessionVerifiedOutputs>
    {
        /// <summary>
        /// The user's verified address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        /// <summary>
        /// The user’s verified date of birth.
        /// </summary>
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public VerificationSessionVerifiedOutputsDob Dob { get; set; }

        /// <summary>
        /// The user's verified email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The user's verified first name.
        /// </summary>
        [JsonProperty("first_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name")]
#endif
        public string FirstName { get; set; }

        /// <summary>
        /// The user's verified id number.
        /// </summary>
        [JsonProperty("id_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number")]
#endif
        public string IdNumber { get; set; }

        /// <summary>
        /// The user's verified id number type.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonProperty("id_number_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number_type")]
#endif
        public string IdNumberType { get; set; }

        /// <summary>
        /// The user's verified last name.
        /// </summary>
        [JsonProperty("last_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name")]
#endif
        public string LastName { get; set; }

        /// <summary>
        /// The user's verified phone number.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The user's verified sex.
        /// One of: <c>[redacted]</c>, <c>female</c>, <c>male</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("sex")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sex")]
#endif
        public string Sex { get; set; }

        /// <summary>
        /// The user's verified place of birth as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_place_of_birth")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unparsed_place_of_birth")]
#endif
        public string UnparsedPlaceOfBirth { get; set; }

        /// <summary>
        /// The user's verified sex as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_sex")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unparsed_sex")]
#endif
        public string UnparsedSex { get; set; }
    }
}
