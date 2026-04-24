// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2OrchestratedCommerceAgreementTerminatedEventData : StripeEntity<V2OrchestratedCommerceAgreementTerminatedEventData>
    {
        /// <summary>
        /// Details about the orchestrator.
        /// </summary>
        [JsonProperty("orchestrator_details")]
        [STJS.JsonPropertyName("orchestrator_details")]
        public V2OrchestratedCommerceAgreementTerminatedEventDataOrchestratorDetails OrchestratorDetails { get; set; }

        /// <summary>
        /// Details about the seller.
        /// </summary>
        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public V2OrchestratedCommerceAgreementTerminatedEventDataSellerDetails SellerDetails { get; set; }

        /// <summary>
        /// The time at which the agreement was terminated.
        /// </summary>
        [JsonProperty("terminated_at")]
        [STJS.JsonPropertyName("terminated_at")]
        public DateTime TerminatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The party that terminated the agreement.
        /// One of: <c>orchestrator</c>, or <c>seller</c>.
        /// </summary>
        [JsonProperty("terminated_by")]
        [STJS.JsonPropertyName("terminated_by")]
        public string TerminatedBy { get; set; }
    }
}
