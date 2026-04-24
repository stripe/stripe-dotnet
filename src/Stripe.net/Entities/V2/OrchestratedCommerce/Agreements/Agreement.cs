// File generated from our OpenAPI spec
namespace Stripe.V2.OrchestratedCommerce
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An Orchestrated Commerce Agreement represents a mutual agreement between a seller and an
    /// orchestrator/agent on the Stripe network.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Agreement : StripeEntity<Agreement>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier for the agreement.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Details about the orchestrator.
        /// </summary>
        [JsonProperty("orchestrator_details")]
        [STJS.JsonPropertyName("orchestrator_details")]
        public AgreementOrchestratorDetails OrchestratorDetails { get; set; }

        /// <summary>
        /// Details about the seller.
        /// </summary>
        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public AgreementSellerDetails SellerDetails { get; set; }

        /// <summary>
        /// The current status of the agreement.
        /// One of: <c>confirmed</c>, <c>initiated</c>, <c>partially_confirmed</c>, or
        /// <c>terminated</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timestamps of key status transitions for the agreement.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public AgreementStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The party that terminated the agreement, if applicable.
        /// One of: <c>orchestrator</c>, or <c>seller</c>.
        /// </summary>
        [JsonProperty("terminated_by")]
        [STJS.JsonPropertyName("terminated_by")]
        public string TerminatedBy { get; set; }
    }
}
