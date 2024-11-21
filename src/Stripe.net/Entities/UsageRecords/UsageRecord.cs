// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Usage records allow you to report customer usage and metrics to Stripe for metered
    /// billing of subscription prices.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/billing/subscriptions/metered-billing">Metered billing</a>.
    ///
    /// This is our legacy usage-based billing API. See the <a
    /// href="https://docs.stripe.com/billing/subscriptions/usage-based">updated usage-based
    /// billing docs</a>.
    /// </summary>
    public class UsageRecord : StripeEntity<UsageRecord>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// The usage quantity for the specified date.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif

        public long Quantity { get; set; }

        /// <summary>
        /// The ID of the subscription item this usage record contains data for.
        /// </summary>
        [JsonProperty("subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_item")]
#endif

        public string SubscriptionItem { get; set; }

        /// <summary>
        /// The timestamp when this usage occurred.
        /// </summary>
        [JsonProperty("timestamp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
