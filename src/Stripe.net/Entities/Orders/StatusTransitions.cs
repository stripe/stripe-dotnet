namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StatusTransitions : StripeEntity
    {
        [JsonProperty("canceled")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Canceled { get; set; }

        [JsonProperty("fulfiled")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Fulfiled { get; set; }

        [JsonProperty("paid")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Paid { get; set; }

        [JsonProperty("returned")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Returned { get; set; }
    }
}
