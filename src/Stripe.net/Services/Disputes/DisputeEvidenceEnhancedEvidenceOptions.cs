// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceEnhancedEvidenceOptions : INestedOptions
    {
        /// <summary>
        /// Evidence provided for Visa Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("visa_compelling_evidence_3")]
        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3Options VisaCompellingEvidence3 { get; set; }
    }
}
