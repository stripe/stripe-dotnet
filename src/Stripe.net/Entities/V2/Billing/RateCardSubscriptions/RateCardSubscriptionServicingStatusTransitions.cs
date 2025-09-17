// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RateCardSubscriptionServicingStatusTransitions : StripeEntity<RateCardSubscriptionServicingStatusTransitions>
    {
        /// <summary>
        /// When the servicing status transitioned to activated.
        /// </summary>
        [JsonProperty("activated_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("activated_at")]
#endif
        public string ActivatedAt { get; set; }

        /// <summary>
        /// When the servicing status transitioned to canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif
        public string CanceledAt { get; set; }

        /// <summary>
        /// When the servicing status transitioned to paused.
        /// </summary>
        [JsonProperty("paused_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paused_at")]
#endif
        public string PausedAt { get; set; }

        /// <summary>
        /// When the servicing is scheduled to transition to activate.
        /// </summary>
        [JsonProperty("will_activate_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("will_activate_at")]
#endif
        public string WillActivateAt { get; set; }

        /// <summary>
        /// When the servicing is scheduled to cancel.
        /// </summary>
        [JsonProperty("will_cancel_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("will_cancel_at")]
#endif
        public string WillCancelAt { get; set; }
    }
}
