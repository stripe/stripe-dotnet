// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeNetworkLifecycleDisputeResponse : StripeEntity<DisputeNetworkLifecycleDisputeResponse>
    {
        /// <summary>
        /// Error message if processing the acquiring merchant's initial dispute response failed.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// Array of <a href="https://docs.stripe.com/api/files">File</a> ids containing evidence
        /// the acquiring merchant provided in support of their initial dispute response.
        /// </summary>
        [JsonProperty("merchant_evidence_files")]
        [STJS.JsonPropertyName("merchant_evidence_files")]
        public List<string> MerchantEvidenceFiles { get; set; }
    }
}
