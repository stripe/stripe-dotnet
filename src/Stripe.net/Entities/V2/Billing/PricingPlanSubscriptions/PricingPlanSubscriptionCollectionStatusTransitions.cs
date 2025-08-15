// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PricingPlanSubscriptionCollectionStatusTransitions : StripeEntity<PricingPlanSubscriptionCollectionStatusTransitions>
    {
        /// <summary>
        /// When the collection status transitioned to awaiting customer action.
        /// </summary>
        [JsonProperty("awaiting_customer_action_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("awaiting_customer_action_at")]
#endif
        public string AwaitingCustomerActionAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to current.
        /// </summary>
        [JsonProperty("current_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_at")]
#endif
        public string CurrentAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to past due.
        /// </summary>
        [JsonProperty("past_due_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("past_due_at")]
#endif
        public string PastDueAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to paused.
        /// </summary>
        [JsonProperty("paused_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paused_at")]
#endif
        public string PausedAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to unpaid.
        /// </summary>
        [JsonProperty("unpaid_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unpaid_at")]
#endif
        public string UnpaidAt { get; set; }
    }
}
