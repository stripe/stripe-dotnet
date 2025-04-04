// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3 : StripeEntity<DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3>
    {
        /// <summary>
        /// Disputed transaction details for Visa Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("disputed_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disputed_transaction")]
#endif
        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransaction DisputedTransaction { get; set; }

        /// <summary>
        /// List of exactly two prior undisputed transaction objects for Visa Compelling Evidence
        /// 3.0 evidence submission.
        /// </summary>
        [JsonProperty("prior_undisputed_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prior_undisputed_transactions")]
#endif
        public List<DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3PriorUndisputedTransaction> PriorUndisputedTransactions { get; set; }
    }
}
