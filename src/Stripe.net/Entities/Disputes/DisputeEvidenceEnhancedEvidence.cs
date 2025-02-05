// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceEnhancedEvidence : StripeEntity<DisputeEvidenceEnhancedEvidence>
    {
        [JsonProperty("visa_compelling_evidence_3")]
        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3 VisaCompellingEvidence3 { get; set; }

        [JsonProperty("visa_compliance")]
        public DisputeEvidenceEnhancedEvidenceVisaCompliance VisaCompliance { get; set; }
    }
}
