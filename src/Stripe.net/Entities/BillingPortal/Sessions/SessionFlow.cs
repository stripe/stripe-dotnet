// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlow : StripeEntity<SessionFlow>
    {
        [JsonProperty("after_completion")]
        public SessionFlowAfterCompletion AfterCompletion { get; set; }

        /// <summary>
        /// Configuration when <c>flow.type=subscription_cancel</c>.
        /// </summary>
        [JsonProperty("subscription_cancel")]
        public SessionFlowSubscriptionCancel SubscriptionCancel { get; set; }

        /// <summary>
        /// Configuration when <c>flow.type=subscription_update</c>.
        /// </summary>
        [JsonProperty("subscription_update")]
        public SessionFlowSubscriptionUpdate SubscriptionUpdate { get; set; }

        /// <summary>
        /// Configuration when <c>flow.type=subscription_update_confirm</c>.
        /// </summary>
        [JsonProperty("subscription_update_confirm")]
        public SessionFlowSubscriptionUpdateConfirm SubscriptionUpdateConfirm { get; set; }

        /// <summary>
        /// Type of flow that the customer will go through.
        /// One of: <c>payment_method_update</c>, <c>subscription_cancel</c>,
        /// <c>subscription_update</c>, or <c>subscription_update_confirm</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
