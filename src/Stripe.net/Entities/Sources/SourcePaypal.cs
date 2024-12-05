// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourcePaypal : StripeEntity<SourcePaypal>
    {
        [JsonProperty("billing_agreement")]
        public string BillingAgreement { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("payer_id")]
        public string PayerId { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("reference_transaction_amount")]
        public string ReferenceTransactionAmount { get; set; }

        [JsonProperty("reference_transaction_charged")]
        public bool ReferenceTransactionCharged { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("verified_email")]
        public string VerifiedEmail { get; set; }
    }
}
