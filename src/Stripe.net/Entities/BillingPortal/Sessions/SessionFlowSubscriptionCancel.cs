// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionFlowSubscriptionCancel : StripeEntity<SessionFlowSubscriptionCancel>
    {
        /// <summary>
        /// Specify a retention strategy to be used in the cancellation flow.
        /// </summary>
        [JsonProperty("retention")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retention")]
#endif
        public SessionFlowSubscriptionCancelRetention Retention { get; set; }

        /// <summary>
        /// The ID of the subscription to be canceled.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }
    }
}
