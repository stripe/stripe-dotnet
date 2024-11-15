// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceDetailsEnhancedEligibility : StripeEntity<DisputeEvidenceDetailsEnhancedEligibility>
    {
        [JsonProperty("visa_compelling_evidence_3")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa_compelling_evidence_3")]
#endif

        public DisputeEvidenceDetailsEnhancedEligibilityVisaCompellingEvidence3 VisaCompellingEvidence3 { get; set; }
    }
}
