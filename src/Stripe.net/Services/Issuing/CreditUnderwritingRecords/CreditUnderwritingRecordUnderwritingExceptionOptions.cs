// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditUnderwritingRecordUnderwritingExceptionOptions : INestedOptions
    {
        /// <summary>
        /// Written explanation for the exception.
        /// </summary>
        [JsonProperty("explanation")]
        [STJS.JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// The decision before the exception was applied.
        /// One of: <c>additional_information_requested</c>, <c>application_rejected</c>,
        /// <c>credit_limit_approved</c>, <c>credit_limit_decreased</c>, <c>credit_line_closed</c>,
        /// <c>no_changes</c>, or <c>withdrawn_by_applicant</c>.
        /// </summary>
        [JsonProperty("original_decision_type")]
        [STJS.JsonPropertyName("original_decision_type")]
        public string OriginalDecisionType { get; set; }
    }
}
