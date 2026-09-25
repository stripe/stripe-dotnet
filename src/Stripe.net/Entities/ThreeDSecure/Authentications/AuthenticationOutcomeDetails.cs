// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationOutcomeDetails : StripeEntity<AuthenticationOutcomeDetails>
    {
        /// <summary>
        /// Universally unique transaction identifier assigned by the issuer to identify the
        /// transaction.
        /// </summary>
        [JsonProperty("acs_transaction_id")]
        [STJS.JsonPropertyName("acs_transaction_id")]
        public string AcsTransactionId { get; set; }

        /// <summary>
        /// The Authentication Response Message (ARes) is the issuer's response to the AReq message.
        /// </summary>
        [JsonProperty("ares")]
        [STJS.JsonPropertyName("ares")]
        public string Ares { get; set; }

        /// <summary>
        /// TransStatus field on the ARes.
        /// One of: <c>A</c>, <c>C</c>, <c>D</c>, <c>I</c>, <c>N</c>, <c>R</c>, <c>S</c>, <c>U</c>,
        /// or <c>Y</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("ares_trans_status")]
        [STJS.JsonPropertyName("ares_trans_status")]
        public string AresTransStatus { get; set; }

        /// <summary>
        /// A 28-character Base64 string proving that 3DS was completed. Store this value securely,
        /// and don’t reuse it for multiple authorizations.
        /// </summary>
        [JsonProperty("cryptogram")]
        [STJS.JsonPropertyName("cryptogram")]
        public string Cryptogram { get; set; }

        /// <summary>
        /// The 3DS2 Directory Server Transaction ID.
        /// </summary>
        [JsonProperty("ds_transaction_id")]
        [STJS.JsonPropertyName("ds_transaction_id")]
        public string DsTransactionId { get; set; }

        /// <summary>
        /// Electronic Commerce Indicator provided by the issuer to indicate the result of this 3DS
        /// Authentication.
        /// </summary>
        [JsonProperty("eci")]
        [STJS.JsonPropertyName("eci")]
        public string Eci { get; set; }

        /// <summary>
        /// Contains details specific to the individual network.
        /// </summary>
        [JsonProperty("network_details")]
        [STJS.JsonPropertyName("network_details")]
        public AuthenticationOutcomeDetailsNetworkDetails NetworkDetails { get; set; }

        /// <summary>
        /// The 3DS protocol version used for this 3DS Authentication.
        /// One of: <c>2.1.0</c>, <c>2.2.0</c>, or <c>2.3.1</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("protocol_version")]
        [STJS.JsonPropertyName("protocol_version")]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// The indicator provided to the issuer by Stripe in the AReq that indicates whether a
        /// challenge is requested for this Authentication. This indicator should match the
        /// flow_preference you specified but may be overridden (for compliance reasons for
        /// example).
        /// One of: <c>01</c>, <c>02</c>, <c>03</c>, <c>04</c>, <c>05</c>, or <c>06</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("requestor_challenge_indicator")]
        [STJS.JsonPropertyName("requestor_challenge_indicator")]
        public string RequestorChallengeIndicator { get; set; }

        /// <summary>
        /// The Results Request Message (RReq) communicates the results of the authentication or
        /// verification.
        /// </summary>
        [JsonProperty("rreq")]
        [STJS.JsonPropertyName("rreq")]
        public string Rreq { get; set; }

        /// <summary>
        /// TransStatus field on the RReq.
        /// One of: <c>A</c>, <c>C</c>, <c>D</c>, <c>I</c>, <c>N</c>, <c>R</c>, <c>S</c>, <c>U</c>,
        /// or <c>Y</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("rreq_trans_status")]
        [STJS.JsonPropertyName("rreq_trans_status")]
        public string RreqTransStatus { get; set; }

        /// <summary>
        /// Universally unique transaction identifier assigned by Stripe to identify the
        /// transaction.
        /// </summary>
        [JsonProperty("three_ds_server_transaction_id")]
        [STJS.JsonPropertyName("three_ds_server_transaction_id")]
        public string ThreeDsServerTransactionId { get; set; }
    }
}
