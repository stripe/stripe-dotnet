// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowSubscriptionCancel : StripeEntity<SessionFlowSubscriptionCancel>
    {
        /// <summary>
        /// The ID of the subscription to be canceled.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
