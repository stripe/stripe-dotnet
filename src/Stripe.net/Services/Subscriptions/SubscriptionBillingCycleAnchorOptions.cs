// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionBillingCycleAnchorOptions : INestedOptions
    {
        /// <summary>
        /// A Unix timestamp within the inclusive bounds of the subscription's current billing
        /// period. For subscriptions with multiple items, it must fall within the intersection of
        /// their current billing periods. Only valid when <c>type</c> is <c>timestamp</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Determines how the billing cycle anchor changes when the subscription is updated.
        /// One of: <c>now</c>, <c>timestamp</c>, or <c>unchanged</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
