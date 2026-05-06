// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionStatusDetailsPaused : StripeEntity<SubscriptionStatusDetailsPaused>
    {
        /// <summary>
        /// Information on the <c>type=subscription</c> pause.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public SubscriptionStatusDetailsPausedSubscription Subscription { get; set; }

        /// <summary>
        /// Unix timestamp in seconds of when the subscription status transitioned to <c>paused</c>.
        /// </summary>
        [JsonProperty("transitioned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("transitioned_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime TransitionedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The type of pause.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
