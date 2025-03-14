// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourcePaypal : StripeEntity<SourcePaypal>
    {
        [JsonProperty("billing_agreement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_agreement")]
#endif
        public string BillingAgreement { get; set; }

        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        [JsonProperty("payer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer_id")]
#endif
        public string PayerId { get; set; }

        [JsonProperty("reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_id")]
#endif
        public string ReferenceId { get; set; }

        [JsonProperty("reference_transaction_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_transaction_amount")]
#endif
        public string ReferenceTransactionAmount { get; set; }

        [JsonProperty("reference_transaction_charged")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_transaction_charged")]
#endif
        public bool ReferenceTransactionCharged { get; set; }

        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }

        [JsonProperty("verified_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_email")]
#endif
        public string VerifiedEmail { get; set; }
    }
}
