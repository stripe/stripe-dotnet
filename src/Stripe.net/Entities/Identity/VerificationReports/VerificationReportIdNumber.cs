// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationReportIdNumber : StripeEntity<VerificationReportIdNumber>
    {
        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public VerificationReportIdNumberDob Dob { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error")]
#endif
        public VerificationReportIdNumberError Error { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        [JsonProperty("first_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name")]
#endif
        public string FirstName { get; set; }

        /// <summary>
        /// ID number. When <c>id_number_type</c> is <c>us_ssn</c>, only the last 4 digits are
        /// present.
        /// </summary>
        [JsonProperty("id_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number")]
#endif
        public string IdNumber { get; set; }

        /// <summary>
        /// Type of ID number.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonProperty("id_number_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number_type")]
#endif
        public string IdNumberType { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        [JsonProperty("last_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name")]
#endif
        public string LastName { get; set; }

        /// <summary>
        /// Status of this <c>id_number</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
