// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionFlowSubscriptionUpdate : StripeEntity<SessionFlowSubscriptionUpdate>
    {
        /// <summary>
        /// The ID of the subscription to be updated.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
