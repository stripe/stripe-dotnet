// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowSubscriptionUpdate : StripeEntity<SessionFlowSubscriptionUpdate>
    {
        /// <summary>
        /// The ID of the subscription to be updated.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
