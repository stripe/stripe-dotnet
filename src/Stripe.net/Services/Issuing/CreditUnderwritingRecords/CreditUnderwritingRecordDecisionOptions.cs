// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditUnderwritingRecordDecisionOptions : INestedOptions
    {
        /// <summary>
        /// Details about the application rejection.
        /// </summary>
        [JsonProperty("application_rejected")]
        [STJS.JsonPropertyName("application_rejected")]
        public CreditUnderwritingRecordDecisionApplicationRejectedOptions ApplicationRejected { get; set; }

        /// <summary>
        /// Details about the credit limit approved. An approved credit limit is required before you
        /// can set a <c>credit_limit_amount</c> in the <a
        /// href="https://docs.stripe.com/api/issuing/credit_policy/">CreditPolicy API</a>.
        /// </summary>
        [JsonProperty("credit_limit_approved")]
        [STJS.JsonPropertyName("credit_limit_approved")]
        public CreditUnderwritingRecordDecisionCreditLimitApprovedOptions CreditLimitApproved { get; set; }

        /// <summary>
        /// Details about the credit limit decreased.
        /// </summary>
        [JsonProperty("credit_limit_decreased")]
        [STJS.JsonPropertyName("credit_limit_decreased")]
        public CreditUnderwritingRecordDecisionCreditLimitDecreasedOptions CreditLimitDecreased { get; set; }

        /// <summary>
        /// Details about the credit line closed.
        /// </summary>
        [JsonProperty("credit_line_closed")]
        [STJS.JsonPropertyName("credit_line_closed")]
        public CreditUnderwritingRecordDecisionCreditLineClosedOptions CreditLineClosed { get; set; }

        /// <summary>
        /// Outcome of the decision.
        /// One of: <c>additional_information_requested</c>, <c>application_rejected</c>,
        /// <c>credit_limit_approved</c>, <c>credit_limit_decreased</c>, <c>credit_line_closed</c>,
        /// <c>no_changes</c>, or <c>withdrawn_by_applicant</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
