// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeNetworkLifecyclePreArbitrationSubmission : StripeEntity<DisputeNetworkLifecyclePreArbitrationSubmission>
    {
        /// <summary>
        /// Error message if processing the acquiring merchant's pre-arbitration submission failed.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// Array of <a href="https://docs.stripe.com/api/files">File</a> ids containing evidence
        /// the acquiring merchant provided with their pre-arbitration submission.
        /// </summary>
        [JsonProperty("merchant_evidence_files")]
        [STJS.JsonPropertyName("merchant_evidence_files")]
        public List<string> MerchantEvidenceFiles { get; set; }
    }
}
