// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceDetails : StripeEntity<DisputeEvidenceDetails>
    {
        /// <summary>
        /// Date by which evidence must be submitted in order to successfully challenge dispute.
        /// Will be 0 if the customer's bank or credit card company doesn't allow a response for
        /// this particular dispute.
        /// </summary>
        [JsonProperty("due_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("due_by")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? DueBy { get; set; }

        [JsonProperty("enhanced_eligibility")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enhanced_eligibility")]
#endif

        public DisputeEvidenceDetailsEnhancedEligibility EnhancedEligibility { get; set; }

        /// <summary>
        /// Whether evidence has been staged for this dispute.
        /// </summary>
        [JsonProperty("has_evidence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("has_evidence")]
#endif

        public bool HasEvidence { get; set; }

        /// <summary>
        /// Whether the last evidence submission was submitted past the due date. Defaults to
        /// <c>false</c> if no evidence submissions have occurred. If <c>true</c>, then delivery of
        /// the latest evidence is <em>not</em> guaranteed.
        /// </summary>
        [JsonProperty("past_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("past_due")]
#endif

        public bool PastDue { get; set; }

        /// <summary>
        /// The number of times evidence has been submitted. Typically, you may only submit evidence
        /// once.
        /// </summary>
        [JsonProperty("submission_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submission_count")]
#endif

        public long SubmissionCount { get; set; }
    }
}
