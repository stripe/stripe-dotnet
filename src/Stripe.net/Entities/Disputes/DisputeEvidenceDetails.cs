// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeEvidenceDetails : StripeEntity<DisputeEvidenceDetails>
    {
        /// <summary>
        /// Date by which evidence must be submitted in order to successfully challenge dispute.
        /// Will be 0 if the customer's bank or credit card company doesn't allow a response for
        /// this particular dispute.
        /// </summary>
        [JsonProperty("due_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("due_by")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DueBy { get; set; }

        [JsonProperty("enhanced_eligibility")]
        [STJS.JsonPropertyName("enhanced_eligibility")]
        public DisputeEvidenceDetailsEnhancedEligibility EnhancedEligibility { get; set; }

        /// <summary>
        /// Whether evidence has been staged for this dispute.
        /// </summary>
        [JsonProperty("has_evidence")]
        [STJS.JsonPropertyName("has_evidence")]
        public bool HasEvidence { get; set; }

        /// <summary>
        /// Whether the last evidence submission was submitted past the due date. Defaults to
        /// <c>false</c> if no evidence submissions have occurred. If <c>true</c>, then delivery of
        /// the latest evidence is <em>not</em> guaranteed.
        /// </summary>
        [JsonProperty("past_due")]
        [STJS.JsonPropertyName("past_due")]
        public bool PastDue { get; set; }

        /// <summary>
        /// The number of times evidence has been submitted. Typically, you may only submit evidence
        /// once.
        /// </summary>
        [JsonProperty("submission_count")]
        [STJS.JsonPropertyName("submission_count")]
        public long SubmissionCount { get; set; }

        /// <summary>
        /// Whether the dispute was submitted manually, with Smart Disputes, or not submitted.
        /// One of: <c>manual</c>, <c>not_submitted</c>, or <c>smart_disputes</c>.
        /// </summary>
        [JsonProperty("submission_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submission_method")]
#endif
        public string SubmissionMethod { get; set; }
    }
}
