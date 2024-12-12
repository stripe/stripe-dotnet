// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditUnderwritingRecordDecisionOptions : INestedOptions
    {
        /// <summary>
        /// Details about the application rejection.
        /// </summary>
        [JsonProperty("application_rejected")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_rejected")]
#endif
        public CreditUnderwritingRecordDecisionApplicationRejectedOptions ApplicationRejected { get; set; }

        /// <summary>
        /// Details about the credit limit approved. An approved credit limit is required before you
        /// can set a <c>credit_limit_amount</c> in the <a
        /// href="https://stripe.com/docs/api/issuing/credit_policy/">CreditPolicy API</a>.
        /// </summary>
        [JsonProperty("credit_limit_approved")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_limit_approved")]
#endif
        public CreditUnderwritingRecordDecisionCreditLimitApprovedOptions CreditLimitApproved { get; set; }

        /// <summary>
        /// Details about the credit limit decreased.
        /// </summary>
        [JsonProperty("credit_limit_decreased")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_limit_decreased")]
#endif
        public CreditUnderwritingRecordDecisionCreditLimitDecreasedOptions CreditLimitDecreased { get; set; }

        /// <summary>
        /// Details about the credit line closed.
        /// </summary>
        [JsonProperty("credit_line_closed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_line_closed")]
#endif
        public CreditUnderwritingRecordDecisionCreditLineClosedOptions CreditLineClosed { get; set; }

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
