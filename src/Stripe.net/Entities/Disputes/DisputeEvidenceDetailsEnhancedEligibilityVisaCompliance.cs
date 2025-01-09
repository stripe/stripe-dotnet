// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceDetailsEnhancedEligibilityVisaCompliance : StripeEntity<DisputeEvidenceDetailsEnhancedEligibilityVisaCompliance>
    {
        /// <summary>
        /// Visa compliance eligibility status.
        /// One of: <c>fee_acknowledged</c>, or <c>requires_fee_acknowledgement</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
