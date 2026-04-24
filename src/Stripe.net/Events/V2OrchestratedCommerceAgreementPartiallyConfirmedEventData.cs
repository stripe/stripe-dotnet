// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2OrchestratedCommerceAgreementPartiallyConfirmedEventData : StripeEntity<V2OrchestratedCommerceAgreementPartiallyConfirmedEventData>
    {
        /// <summary>
        /// The time at which the orchestrator confirmed the agreement.
        /// </summary>
        [JsonProperty("orchestrator_confirmed_at")]
        [STJS.JsonPropertyName("orchestrator_confirmed_at")]
        public DateTime OrchestratorConfirmedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details about the orchestrator.
        /// </summary>
        [JsonProperty("orchestrator_details")]
        [STJS.JsonPropertyName("orchestrator_details")]
        public V2OrchestratedCommerceAgreementPartiallyConfirmedEventDataOrchestratorDetails OrchestratorDetails { get; set; }

        /// <summary>
        /// The time at which the seller confirmed the agreement.
        /// </summary>
        [JsonProperty("seller_confirmed_at")]
        [STJS.JsonPropertyName("seller_confirmed_at")]
        public DateTime SellerConfirmedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details about the seller.
        /// </summary>
        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public V2OrchestratedCommerceAgreementPartiallyConfirmedEventDataSellerDetails SellerDetails { get; set; }
    }
}
