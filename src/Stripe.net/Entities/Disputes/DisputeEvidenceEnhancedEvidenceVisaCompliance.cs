// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceEnhancedEvidenceVisaCompliance : StripeEntity<DisputeEvidenceEnhancedEvidenceVisaCompliance>
    {
        /// <summary>
        /// A field acknowledging the fee incurred when countering a Visa Compliance dispute. If
        /// this field is set to true, evidence can be submitted for the compliance dispute, and you
        /// may incur a $500 fee if the case is lost.
        /// </summary>
        [JsonProperty("fee_acknowledged")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_acknowledged")]
#endif
        public bool FeeAcknowledged { get; set; }
    }
}
