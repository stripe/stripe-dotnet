// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordException : StripeEntity<CreditUnderwritingRecordException>
    {
        /// <summary>
        /// The decision before the exception was applied.
        /// One of: <c>additional_information_requested</c>, <c>application_rejected</c>,
        /// <c>credit_limit_approved</c>, <c>credit_limit_decreased</c>, <c>credit_line_closed</c>,
        /// <c>no_changes</c>, or <c>withdrawn_by_applicant</c>.
        /// </summary>
        [JsonProperty("original_decision_type")]
        public string OriginalDecisionType { get; set; }

        /// <summary>
        /// Written explanation for the exception.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
