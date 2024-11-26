// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationReportListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A string to reference this user. This can be a customer ID, a session ID, or similar,
        /// and can be used to reconcile this verification with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_reference_id")]
#endif
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Only return VerificationReports of this type.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Only return VerificationReports created by this VerificationSession ID. It is allowed to
        /// provide a VerificationIntent ID.
        /// </summary>
        [JsonProperty("verification_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_session")]
#endif
        public string VerificationSession { get; set; }
    }
}
