// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2OrchestratedCommerceAgreementCreatedEventData : StripeEntity<V2OrchestratedCommerceAgreementCreatedEventData>
    {
        /// <summary>
        /// The time at which the agreement was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The party that initiated the agreement.
        /// One of: <c>orchestrator</c>, or <c>seller</c>.
        /// </summary>
        [JsonProperty("initiated_by")]
        [STJS.JsonPropertyName("initiated_by")]
        public string InitiatedBy { get; set; }

        /// <summary>
        /// Details about the orchestrator.
        /// </summary>
        [JsonProperty("orchestrator_details")]
        [STJS.JsonPropertyName("orchestrator_details")]
        public V2OrchestratedCommerceAgreementCreatedEventDataOrchestratorDetails OrchestratorDetails { get; set; }

        /// <summary>
        /// Details about the seller.
        /// </summary>
        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public V2OrchestratedCommerceAgreementCreatedEventDataSellerDetails SellerDetails { get; set; }
    }
}
