// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceEnhancedEvidenceOptions : INestedOptions
    {
        /// <summary>
        /// Evidence provided for Visa Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("visa_compelling_evidence_3")]
        [STJS.JsonPropertyName("visa_compelling_evidence_3")]
        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3Options VisaCompellingEvidence3 { get; set; }

        /// <summary>
        /// Evidence provided for Visa compliance evidence submission.
        /// </summary>
        [JsonProperty("visa_compliance")]
        [STJS.JsonPropertyName("visa_compliance")]
        public DisputeEvidenceEnhancedEvidenceVisaComplianceOptions VisaCompliance { get; set; }
    }
}
