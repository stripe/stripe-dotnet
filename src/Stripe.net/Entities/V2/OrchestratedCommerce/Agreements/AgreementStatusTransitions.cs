// File generated from our OpenAPI spec
namespace Stripe.V2.OrchestratedCommerce
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AgreementStatusTransitions : StripeEntity<AgreementStatusTransitions>
    {
        /// <summary>
        /// The time at which the orchestrator confirmed the agreement.
        /// </summary>
        [JsonProperty("orchestrator_confirmed_at")]
        [STJS.JsonPropertyName("orchestrator_confirmed_at")]
        public DateTime? OrchestratorConfirmedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time at which the seller confirmed the agreement.
        /// </summary>
        [JsonProperty("seller_confirmed_at")]
        [STJS.JsonPropertyName("seller_confirmed_at")]
        public DateTime? SellerConfirmedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time at which the agreement was terminated.
        /// </summary>
        [JsonProperty("terminated_at")]
        [STJS.JsonPropertyName("terminated_at")]
        public DateTime? TerminatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
