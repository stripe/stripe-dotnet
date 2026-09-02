// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportPhone : StripeEntity<VerificationReportPhone>
    {
        /// <summary>
        /// Confidence that the provided address matches the phone records.
        /// One of: <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("address_match_confidence")]
        [STJS.JsonPropertyName("address_match_confidence")]
        public string AddressMatchConfidence { get; set; }

        /// <summary>
        /// The phone carrier.
        /// </summary>
        [JsonProperty("carrier")]
        [STJS.JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public VerificationReportPhoneError Error { get; set; }

        /// <summary>
        /// The type of phone line.
        /// One of: <c>landline</c>, <c>mobile</c>, or <c>voip</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("line_type")]
        [STJS.JsonPropertyName("line_type")]
        public string LineType { get; set; }

        /// <summary>
        /// Confidence that the provided name matches the phone records.
        /// One of: <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("name_match_confidence")]
        [STJS.JsonPropertyName("name_match_confidence")]
        public string NameMatchConfidence { get; set; }

        /// <summary>
        /// The observed number of days the person has owned the phone number.
        /// </summary>
        [JsonProperty("observed_phone_tenure_days")]
        [STJS.JsonPropertyName("observed_phone_tenure_days")]
        public decimal ObservedPhoneTenureDays { get; set; }

        /// <summary>
        /// Phone to be verified.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Status of this <c>phone</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
