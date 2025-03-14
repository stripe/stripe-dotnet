// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditUnderwritingRecordUnderwritingException : StripeEntity<CreditUnderwritingRecordUnderwritingException>
    {
        /// <summary>
        /// Written explanation for the exception.
        /// </summary>
        [JsonProperty("explanation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("explanation")]
#endif
        public string Explanation { get; set; }

        /// <summary>
        /// The decision before the exception was applied.
        /// One of: <c>additional_information_requested</c>, <c>application_rejected</c>,
        /// <c>credit_limit_approved</c>, <c>credit_limit_decreased</c>, <c>credit_line_closed</c>,
        /// <c>no_changes</c>, or <c>withdrawn_by_applicant</c>.
        /// </summary>
        [JsonProperty("original_decision_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_decision_type")]
#endif
        public string OriginalDecisionType { get; set; }
    }
}
