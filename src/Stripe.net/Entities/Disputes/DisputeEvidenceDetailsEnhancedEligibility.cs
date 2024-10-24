// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceDetailsEnhancedEligibility : StripeEntity<DisputeEvidenceDetailsEnhancedEligibility>
    {
        [JsonProperty("visa_compelling_evidence_3")]
        public DisputeEvidenceDetailsEnhancedEligibilityVisaCompellingEvidence3 VisaCompellingEvidence3 { get; set; }
    }
}
