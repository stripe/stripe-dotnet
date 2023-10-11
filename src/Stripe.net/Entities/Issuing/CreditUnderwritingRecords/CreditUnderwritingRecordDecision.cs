// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordDecision : StripeEntity<CreditUnderwritingRecordDecision>
    {
        /// <summary>
        /// Details about a decision application_rejected.
        /// </summary>
        [JsonProperty("application_rejected")]
        public CreditUnderwritingRecordDecisionApplicationRejected ApplicationRejected { get; set; }

        /// <summary>
        /// Details about a decision credit_limit_approved.
        /// </summary>
        [JsonProperty("credit_limit_approved")]
        public CreditUnderwritingRecordDecisionCreditLimitApproved CreditLimitApproved { get; set; }

        /// <summary>
        /// Details about a decision credit_limit_decreased.
        /// </summary>
        [JsonProperty("credit_limit_decreased")]
        public CreditUnderwritingRecordDecisionCreditLimitDecreased CreditLimitDecreased { get; set; }

        /// <summary>
        /// Details about a decision credit_line_closed.
        /// </summary>
        [JsonProperty("credit_line_closed")]
        public CreditUnderwritingRecordDecisionCreditLineClosed CreditLineClosed { get; set; }

        /// <summary>
        /// Outcome of the decision.
        /// One of: <c>additional_information_requested</c>, <c>application_rejected</c>,
        /// <c>credit_limit_approved</c>, <c>credit_limit_decreased</c>, <c>credit_line_closed</c>,
        /// <c>no_changes</c>, or <c>withdrawn_by_applicant</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
