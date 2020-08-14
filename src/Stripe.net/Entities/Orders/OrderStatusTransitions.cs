namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderStatusTransitions : StripeEntity<OrderStatusTransitions>
    {
        /// <summary>
        /// The time that the order was canceled.
        /// </summary>
        [JsonProperty("canceled")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Canceled { get; set; }

        /// <summary>
        /// The time that the order was fulfilled.
        /// </summary>
        [JsonProperty("fulfiled")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Fulfiled { get; set; }

        /// <summary>
        /// The time that the order was paid.
        /// </summary>
        [JsonProperty("paid")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Paid { get; set; }

        /// <summary>
        /// The time that the order was returned.
        /// </summary>
        [JsonProperty("returned")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Returned { get; set; }
    }
}
