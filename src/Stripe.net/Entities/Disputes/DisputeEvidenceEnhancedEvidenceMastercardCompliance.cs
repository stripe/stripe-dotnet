// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeEvidenceEnhancedEvidenceMastercardCompliance : StripeEntity<DisputeEvidenceEnhancedEvidenceMastercardCompliance>
    {
        /// <summary>
        /// A field acknowledging the fee incurred when countering a Mastercard compliance dispute.
        /// If this field is set to true, evidence can be submitted for the compliance dispute.
        /// </summary>
        [JsonProperty("fee_acknowledged")]
        [STJS.JsonPropertyName("fee_acknowledged")]
        public bool FeeAcknowledged { get; set; }
    }
}
