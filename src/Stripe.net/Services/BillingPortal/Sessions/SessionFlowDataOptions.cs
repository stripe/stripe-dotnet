// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowDataOptions : INestedOptions
    {
        /// <summary>
        /// Behavior after the flow is completed.
        /// </summary>
        [JsonProperty("after_completion")]
        public SessionFlowDataAfterCompletionOptions AfterCompletion { get; set; }

        /// <summary>
        /// Configuration when <c>flow_data.type=subscription_cancel</c>.
        /// </summary>
        [JsonProperty("subscription_cancel")]
        public SessionFlowDataSubscriptionCancelOptions SubscriptionCancel { get; set; }

        /// <summary>
        /// Configuration when <c>flow_data.type=subscription_update</c>.
        /// </summary>
        [JsonProperty("subscription_update")]
        public SessionFlowDataSubscriptionUpdateOptions SubscriptionUpdate { get; set; }

        /// <summary>
        /// Configuration when <c>flow_data.type=subscription_update_confirm</c>.
        /// </summary>
        [JsonProperty("subscription_update_confirm")]
        public SessionFlowDataSubscriptionUpdateConfirmOptions SubscriptionUpdateConfirm { get; set; }

        /// <summary>
        /// Type of flow that the customer will go through.
        /// One of: <c>payment_method_update</c>, <c>subscription_cancel</c>,
        /// <c>subscription_update</c>, or <c>subscription_update_confirm</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
