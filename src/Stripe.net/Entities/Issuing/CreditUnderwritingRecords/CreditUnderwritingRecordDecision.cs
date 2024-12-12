// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditUnderwritingRecordDecision : StripeEntity<CreditUnderwritingRecordDecision>
    {
        /// <summary>
        /// Details about a decision application_rejected.
        /// </summary>
        [JsonProperty("application_rejected")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_rejected")]
#endif
        public CreditUnderwritingRecordDecisionApplicationRejected ApplicationRejected { get; set; }

        /// <summary>
        /// Details about a decision credit_limit_approved.
        /// </summary>
        [JsonProperty("credit_limit_approved")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_limit_approved")]
#endif
        public CreditUnderwritingRecordDecisionCreditLimitApproved CreditLimitApproved { get; set; }

        /// <summary>
        /// Details about a decision credit_limit_decreased.
        /// </summary>
        [JsonProperty("credit_limit_decreased")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_limit_decreased")]
#endif
        public CreditUnderwritingRecordDecisionCreditLimitDecreased CreditLimitDecreased { get; set; }

        /// <summary>
        /// Details about a decision credit_line_closed.
        /// </summary>
        [JsonProperty("credit_line_closed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_line_closed")]
#endif
        public CreditUnderwritingRecordDecisionCreditLineClosed CreditLineClosed { get; set; }

        /// <summary>
        /// Outcome of the decision.
        /// One of: <c>additional_information_requested</c>, <c>application_rejected</c>,
        /// <c>credit_limit_approved</c>, <c>credit_limit_decreased</c>, <c>credit_line_closed</c>,
        /// <c>no_changes</c>, or <c>withdrawn_by_applicant</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
