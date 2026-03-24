// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3 : StripeEntity<DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3>
    {
        /// <summary>
        /// Disputed transaction details for Visa Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("disputed_transaction")]
        [STJS.JsonPropertyName("disputed_transaction")]
        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransaction DisputedTransaction { get; set; }

        /// <summary>
        /// List of exactly two prior undisputed transaction objects for Visa Compelling Evidence
        /// 3.0 evidence submission.
        /// </summary>
        [JsonProperty("prior_undisputed_transactions")]
        [STJS.JsonPropertyName("prior_undisputed_transactions")]
        public List<DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3PriorUndisputedTransaction> PriorUndisputedTransactions { get; set; }
    }
}
