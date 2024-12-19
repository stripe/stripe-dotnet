// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceEnhancedEvidenceOptions : INestedOptions
    {
        /// <summary>
        /// Evidence provided for Visa Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("visa_compelling_evidence_3")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa_compelling_evidence_3")]
#endif
        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3Options VisaCompellingEvidence3 { get; set; }

        /// <summary>
        /// Evidence provided for Visa compliance evidence submission.
        /// </summary>
        [JsonProperty("visa_compliance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa_compliance")]
#endif
        public DisputeEvidenceEnhancedEvidenceVisaComplianceOptions VisaCompliance { get; set; }
    }
}
