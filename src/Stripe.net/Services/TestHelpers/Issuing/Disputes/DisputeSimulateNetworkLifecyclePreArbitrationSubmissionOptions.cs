// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeSimulateNetworkLifecyclePreArbitrationSubmissionOptions : BaseOptions
    {
        /// <summary>
        /// Controls the acquiring merchant's simulated submitted evidence files for the
        /// pre-arbitration submission stage.
        /// </summary>
        [JsonProperty("merchant_evidence_files")]
        [STJS.JsonPropertyName("merchant_evidence_files")]
        public DisputeMerchantEvidenceFilesOptions MerchantEvidenceFiles { get; set; }
    }
}
