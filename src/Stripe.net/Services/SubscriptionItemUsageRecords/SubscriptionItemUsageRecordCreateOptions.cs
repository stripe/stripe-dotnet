// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionItemUsageRecordCreateOptions : BaseOptions
    {
        /// <summary>
        /// Valid values are <c>increment</c> (default) or <c>set</c>. When using <c>increment</c>
        /// the specified <c>quantity</c> will be added to the usage at the specified timestamp. The
        /// <c>set</c> action will overwrite the usage quantity at that timestamp. If the
        /// subscription has <a
        /// href="https://stripe.com/docs/api/subscriptions/object#subscription_object-billing_thresholds">billing
        /// thresholds</a>, <c>increment</c> is the only allowed value.
        /// One of: <c>increment</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("action")]
#endif

        public string Action { get; set; }

        /// <summary>
        /// The usage quantity for the specified timestamp.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif

        public long? Quantity { get; set; }

        /// <summary>
        /// The timestamp for the usage event. This timestamp must be within the current billing
        /// period of the subscription of the provided <c>subscription_item</c>, and must not be in
        /// the future. When passing <c>"now"</c>, Stripe records usage for the current time.
        /// Default is <c>"now"</c> if a value is not provided.
        /// </summary>
        [JsonProperty("timestamp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionItemUsageRecordTimestamp> Timestamp { get; set; }
    }
}
