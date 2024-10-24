// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3Options : INestedOptions
    {
        /// <summary>
        /// Disputed transaction details for Visa Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("disputed_transaction")]
        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransactionOptions DisputedTransaction { get; set; }

        /// <summary>
        /// List of exactly two prior undisputed transaction objects for Visa Compelling Evidence
        /// 3.0 evidence submission.
        /// </summary>
        [JsonProperty("prior_undisputed_transactions")]
        public List<DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3PriorUndisputedTransactionOptions> PriorUndisputedTransactions { get; set; }
    }
}
