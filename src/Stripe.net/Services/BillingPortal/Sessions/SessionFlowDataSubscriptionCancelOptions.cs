// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowDataSubscriptionCancelOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the subscription to be canceled.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
