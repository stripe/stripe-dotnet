// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationNetworkData : StripeEntity<AuthorizationNetworkData>
    {
        /// <summary>
        /// Identifier assigned to the acquirer by the card network. Sometimes this value is not
        /// provided by the network; in this case, the value will be <c>null</c>.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acquiring_institution_id")]
#endif

        public string AcquiringInstitutionId { get; set; }

        /// <summary>
        /// The System Trace Audit Number (STAN) is a 6-digit identifier assigned by the acquirer.
        /// Prefer <c>network_data.transaction_id</c> if present, unless you have special
        /// requirements.
        /// </summary>
        [JsonProperty("system_trace_audit_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("system_trace_audit_number")]
#endif

        public string SystemTraceAuditNumber { get; set; }

        /// <summary>
        /// Unique identifier for the authorization assigned by the card network used to match
        /// subsequent messages, disputes, and transactions.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif

        public string TransactionId { get; set; }
    }
}
