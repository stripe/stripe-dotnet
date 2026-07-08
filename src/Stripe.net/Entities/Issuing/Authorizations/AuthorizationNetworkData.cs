// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationNetworkData : StripeEntity<AuthorizationNetworkData>
    {
        /// <summary>
        /// Country code of the acquirer assigned by the card network.
        /// </summary>
        [JsonProperty("acquiring_institution_country")]
        [STJS.JsonPropertyName("acquiring_institution_country")]
        public string AcquiringInstitutionCountry { get; set; }

        /// <summary>
        /// Identifier assigned to the acquirer by the card network. Sometimes this value is not
        /// provided by the network; in this case, the value will be <c>null</c>.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
        [STJS.JsonPropertyName("acquiring_institution_id")]
        public string AcquiringInstitutionId { get; set; }

        /// <summary>
        /// Identifier assigned by the acquirer to track all messages related to this transaction.
        /// </summary>
        [JsonProperty("retrieval_reference_number")]
        [STJS.JsonPropertyName("retrieval_reference_number")]
        public string RetrievalReferenceNumber { get; set; }

        /// <summary>
        /// The System Trace Audit Number (STAN) is a 6-digit identifier assigned by the acquirer.
        /// Prefer <c>network_data.transaction_id</c> if present, unless you have special
        /// requirements.
        /// </summary>
        [JsonProperty("system_trace_audit_number")]
        [STJS.JsonPropertyName("system_trace_audit_number")]
        public string SystemTraceAuditNumber { get; set; }

        /// <summary>
        /// Unique identifier for the authorization assigned by the card network used to match
        /// subsequent messages, disputes, and transactions.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
