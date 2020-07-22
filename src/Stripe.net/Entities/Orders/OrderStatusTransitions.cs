namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderStatusTransitions : StripeEntity<OrderStatusTransitions>
    {
        [JsonProperty("canceled")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Canceled { get; set; }

        [JsonProperty("fulfiled")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Fulfiled { get; set; }

        [JsonProperty("paid")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Paid { get; set; }

        [JsonProperty("returned")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Returned { get; set; }
    }
}
