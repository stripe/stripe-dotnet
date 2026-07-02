// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerVerification : StripeEntity<CustomerVerification>
    {
        /// <summary>
        /// List of errors associated with the verification.
        /// One of: <c>id_document_verification_failed</c>, <c>phone_verification_failed</c>, or
        /// <c>user_has_reached_max_verification_attempts</c>.
        /// </summary>
        [JsonProperty("errors")]
        [STJS.JsonPropertyName("errors")]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Type of verification.
        /// One of: <c>id_document_verified</c>, <c>kyc_verified</c>, or <c>phone_verified</c>.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Outcome of the verification.
        /// One of: <c>not_available</c>, <c>not_started</c>, <c>pending</c>, <c>rejected</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
