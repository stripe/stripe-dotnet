// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionServicingStatusTransitions : StripeEntity<PricingPlanSubscriptionServicingStatusTransitions>
    {
        /// <summary>
        /// When the servicing status transitioned to activated.
        /// </summary>
        [JsonProperty("activated_at")]
        [STJS.JsonPropertyName("activated_at")]
        public string ActivatedAt { get; set; }

        /// <summary>
        /// When the servicing status transitioned to canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public string CanceledAt { get; set; }

        /// <summary>
        /// When the servicing status transitioned to paused.
        /// </summary>
        [JsonProperty("paused_at")]
        [STJS.JsonPropertyName("paused_at")]
        public string PausedAt { get; set; }

        /// <summary>
        /// When the servicing is scheduled to transition to activate.
        /// </summary>
        [JsonProperty("will_activate_at")]
        [STJS.JsonPropertyName("will_activate_at")]
        public string WillActivateAt { get; set; }

        /// <summary>
        /// When the servicing is scheduled to cancel.
        /// </summary>
        [JsonProperty("will_cancel_at")]
        [STJS.JsonPropertyName("will_cancel_at")]
        public string WillCancelAt { get; set; }
    }
}
