namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UsageRecord : StripeEntity<UsageRecord>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The usage quantity for the specified date.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The ID of the subscription item this usage record contains data for.
        /// </summary>
        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }

        /// <summary>
        /// The timestamp when this usage occurred.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
