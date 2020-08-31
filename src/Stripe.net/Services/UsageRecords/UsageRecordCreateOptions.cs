namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UsageRecordCreateOptions : BaseOptions
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
        public string Action { get; set; }

        /// <summary>
        /// The usage quantity for the specified timestamp.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The timestamp for the usage event. This timestamp must be within the current billing
        /// period of the subscription of the provided <c>subscription_item</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }
    }
}
