// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeNetworkLifecycle : StripeEntity<DisputeNetworkLifecycle>
    {
        /// <summary>
        /// Information related to the acquiring merchant's initial response to this dispute.
        /// </summary>
        [JsonProperty("dispute_response")]
        [STJS.JsonPropertyName("dispute_response")]
        public DisputeNetworkLifecycleDisputeResponse DisputeResponse { get; set; }

        /// <summary>
        /// Information related to the acquiring merchant's pre-arbitration response for this
        /// dispute.
        /// </summary>
        [JsonProperty("pre_arbitration_response")]
        [STJS.JsonPropertyName("pre_arbitration_response")]
        public DisputeNetworkLifecyclePreArbitrationResponse PreArbitrationResponse { get; set; }

        /// <summary>
        /// Information related to the acquiring merchant's pre-arbitration submission for this
        /// dispute.
        /// </summary>
        [JsonProperty("pre_arbitration_submission")]
        [STJS.JsonPropertyName("pre_arbitration_submission")]
        public DisputeNetworkLifecyclePreArbitrationSubmission PreArbitrationSubmission { get; set; }
    }
}
