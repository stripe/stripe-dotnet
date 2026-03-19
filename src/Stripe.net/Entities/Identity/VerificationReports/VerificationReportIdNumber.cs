// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportIdNumber : StripeEntity<VerificationReportIdNumber>
    {
        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public VerificationReportIdNumberDob Dob { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public VerificationReportIdNumberError Error { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        [JsonProperty("first_name")]
        [STJS.JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// ID number. When <c>id_number_type</c> is <c>us_ssn</c>, only the last 4 digits are
        /// present.
        /// </summary>
        [JsonProperty("id_number")]
        [STJS.JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// Type of ID number.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonProperty("id_number_type")]
        [STJS.JsonPropertyName("id_number_type")]
        public string IdNumberType { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        [JsonProperty("last_name")]
        [STJS.JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Status of this <c>id_number</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
