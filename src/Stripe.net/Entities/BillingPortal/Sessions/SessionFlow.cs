// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionFlow : StripeEntity<SessionFlow>
    {
        [JsonProperty("after_completion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("after_completion")]
#endif
        public SessionFlowAfterCompletion AfterCompletion { get; set; }

        /// <summary>
        /// Configuration when <c>flow.type=subscription_cancel</c>.
        /// </summary>
        [JsonProperty("subscription_cancel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel")]
#endif
        public SessionFlowSubscriptionCancel SubscriptionCancel { get; set; }

        /// <summary>
        /// Configuration when <c>flow.type=subscription_update</c>.
        /// </summary>
        [JsonProperty("subscription_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_update")]
#endif
        public SessionFlowSubscriptionUpdate SubscriptionUpdate { get; set; }

        /// <summary>
        /// Configuration when <c>flow.type=subscription_update_confirm</c>.
        /// </summary>
        [JsonProperty("subscription_update_confirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_update_confirm")]
#endif
        public SessionFlowSubscriptionUpdateConfirm SubscriptionUpdateConfirm { get; set; }

        /// <summary>
        /// Type of flow that the customer will go through.
        /// One of: <c>payment_method_update</c>, <c>subscription_cancel</c>,
        /// <c>subscription_update</c>, or <c>subscription_update_confirm</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
