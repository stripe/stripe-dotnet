using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeEvidenceDetails : StripeEntity
    {
        [JsonProperty("due_by")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? DueBy { get; set; }

        [JsonProperty("has_evidence")]
        public bool HasEvidence { get; set; }

        [JsonProperty("past_due")]
        public bool PastDue { get; set; }

        [JsonProperty("submission_count")]
        public int SubmissionCount { get; set; }
    }
}