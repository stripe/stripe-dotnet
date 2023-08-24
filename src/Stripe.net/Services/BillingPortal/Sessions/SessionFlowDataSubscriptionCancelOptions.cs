// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowDataSubscriptionCancelOptions : INestedOptions
    {
        /// <summary>
        /// Specify a retention strategy to be used in the cancellation flow.
        /// </summary>
        [JsonProperty("retention")]
        public SessionFlowDataSubscriptionCancelRetentionOptions Retention { get; set; }

        /// <summary>
        /// The ID of the subscription to be canceled.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
