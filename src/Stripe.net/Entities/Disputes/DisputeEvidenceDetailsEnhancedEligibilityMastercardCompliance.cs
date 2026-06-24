// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeEvidenceDetailsEnhancedEligibilityMastercardCompliance : StripeEntity<DisputeEvidenceDetailsEnhancedEligibilityMastercardCompliance>
    {
        /// <summary>
        /// Mastercard compliance eligibility status.
        /// One of: <c>fee_acknowledged</c>, or <c>requires_fee_acknowledgement</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
