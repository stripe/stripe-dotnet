// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionFlowSubscriptionCancel : StripeEntity<SessionFlowSubscriptionCancel>
    {
        /// <summary>
        /// Specify a retention strategy to be used in the cancellation flow.
        /// </summary>
        [JsonProperty("retention")]
        [STJS.JsonPropertyName("retention")]
        public SessionFlowSubscriptionCancelRetention Retention { get; set; }

        /// <summary>
        /// The ID of the subscription to be canceled.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
