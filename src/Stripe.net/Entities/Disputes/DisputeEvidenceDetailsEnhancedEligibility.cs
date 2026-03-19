// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeEvidenceDetailsEnhancedEligibility : StripeEntity<DisputeEvidenceDetailsEnhancedEligibility>
    {
        [JsonProperty("visa_compelling_evidence_3")]
        [STJS.JsonPropertyName("visa_compelling_evidence_3")]
        public DisputeEvidenceDetailsEnhancedEligibilityVisaCompellingEvidence3 VisaCompellingEvidence3 { get; set; }

        [JsonProperty("visa_compliance")]
        [STJS.JsonPropertyName("visa_compliance")]
        public DisputeEvidenceDetailsEnhancedEligibilityVisaCompliance VisaCompliance { get; set; }
    }
}
