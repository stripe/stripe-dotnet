// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseSchedulePausePauseAtOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp at which to pause the subscription. Required when <c>type</c> is
        /// <c>timestamp</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// When to pause the subscription. Use <c>now</c> to pause immediately or <c>timestamp</c>
        /// to pause at a specific time.
        /// One of: <c>now</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
