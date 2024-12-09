// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceDetailsEnhancedEligibilityVisaCompliance : StripeEntity<DisputeEvidenceDetailsEnhancedEligibilityVisaCompliance>
    {
        /// <summary>
        /// Visa Compelling Evidence 3.0 eligibility status.
        /// One of: <c>fee_acknowledged</c>, or <c>requires_fee_acknowledgement</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
