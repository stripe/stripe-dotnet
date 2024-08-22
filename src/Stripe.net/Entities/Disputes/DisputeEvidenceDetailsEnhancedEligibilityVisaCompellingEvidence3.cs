// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeEvidenceDetailsEnhancedEligibilityVisaCompellingEvidence3 : StripeEntity<DisputeEvidenceDetailsEnhancedEligibilityVisaCompellingEvidence3>
    {
        /// <summary>
        /// List of actions required to qualify dispute for Visa Compelling Evidence 3.0 evidence
        /// submission.
        /// One of: <c>missing_customer_identifiers</c>,
        /// <c>missing_disputed_transaction_description</c>, <c>missing_merchandise_or_services</c>,
        /// <c>missing_prior_undisputed_transaction_description</c>, or
        /// <c>missing_prior_undisputed_transactions</c>.
        /// </summary>
        [JsonProperty("required_actions")]
        public List<string> RequiredActions { get; set; }

        /// <summary>
        /// Visa Compelling Evidence 3.0 eligibility status.
        /// One of: <c>not_qualified</c>, <c>qualified</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
