// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerKycTier : StripeEntity<CustomerKycTier>
    {
        /// <summary>
        /// The KYC tier level (e.g., l0, l1, l2).
        /// One of: <c>l0</c>, <c>l1</c>, or <c>l2</c>.
        /// </summary>
        [JsonProperty("tier")]
        [STJS.JsonPropertyName("tier")]
        public string Tier { get; set; }

        /// <summary>
        /// List of errors associated with this KYC tier verification.
        /// One of: <c>id_document_verification_failed</c>, <c>phone_verification_failed</c>, or
        /// <c>user_has_reached_max_verification_attempts</c>.
        /// </summary>
        [JsonProperty("verification_errors")]
        [STJS.JsonPropertyName("verification_errors")]
        public List<string> VerificationErrors { get; set; }

        /// <summary>
        /// The verification status for this KYC tier.
        /// One of: <c>not_available</c>, <c>not_started</c>, <c>pending</c>, <c>rejected</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("verification_status")]
        [STJS.JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; }
    }
}
