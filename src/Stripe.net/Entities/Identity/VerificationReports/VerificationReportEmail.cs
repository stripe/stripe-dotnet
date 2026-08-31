// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportEmail : StripeEntity<VerificationReportEmail>
    {
        /// <summary>
        /// Confidence that the provided address matches the email records.
        /// One of: <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("address_match_confidence")]
        [STJS.JsonPropertyName("address_match_confidence")]
        public string AddressMatchConfidence { get; set; }

        /// <summary>
        /// Additional email verification details.
        /// </summary>
        [JsonProperty("details")]
        [STJS.JsonPropertyName("details")]
        public VerificationReportEmailDetails Details { get; set; }

        /// <summary>
        /// Two-letter country code of the email domain's country.
        /// </summary>
        [JsonProperty("domain_country")]
        [STJS.JsonPropertyName("domain_country")]
        public string DomainCountry { get; set; }

        /// <summary>
        /// Email to be verified.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Confidence that the email address exists.
        /// One of: <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("email_exists_confidence")]
        [STJS.JsonPropertyName("email_exists_confidence")]
        public string EmailExistsConfidence { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public VerificationReportEmailError Error { get; set; }

        /// <summary>
        /// Confidence that the provided name matches the email records.
        /// One of: <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("name_match_confidence")]
        [STJS.JsonPropertyName("name_match_confidence")]
        public string NameMatchConfidence { get; set; }

        /// <summary>
        /// The observed number of days the email domain has existed.
        /// </summary>
        [JsonProperty("observed_domain_tenure_days")]
        [STJS.JsonPropertyName("observed_domain_tenure_days")]
        public decimal ObservedDomainTenureDays { get; set; }

        /// <summary>
        /// The observed number of days the email address has existed.
        /// </summary>
        [JsonProperty("observed_email_tenure_days")]
        [STJS.JsonPropertyName("observed_email_tenure_days")]
        public decimal ObservedEmailTenureDays { get; set; }

        /// <summary>
        /// Confidence that the provided phone matches the email records.
        /// One of: <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("phone_match_confidence")]
        [STJS.JsonPropertyName("phone_match_confidence")]
        public string PhoneMatchConfidence { get; set; }

        /// <summary>
        /// Status of this <c>email</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
