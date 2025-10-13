// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationReportListOptions : ListOptions
    {
        /// <summary>
        /// Only return VerificationReports that were blocked by this BlocklistEntry id.
        /// </summary>
        [JsonProperty("blocked_by_entry")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blocked_by_entry")]
#endif
        public string BlockedByEntry { get; set; }

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
        /// Only return VerificationReports that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

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
