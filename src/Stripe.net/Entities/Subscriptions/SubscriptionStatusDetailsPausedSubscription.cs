// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionStatusDetailsPausedSubscription : StripeEntity<SubscriptionStatusDetailsPausedSubscription>
    {
        /// <summary>
        /// The reason that the subscription was paused.
        /// One of: <c>pause_requested</c>, <c>system</c>, or
        /// <c>trial_end_without_payment_method</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
