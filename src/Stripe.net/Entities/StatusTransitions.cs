namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StatusTransitions : StripeEntity
    {
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("canceled")]
        public DateTime? Canceled { get; set; }

        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("fulfiled")]
        public DateTime? Fulfiled { get; set; }

        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("paid")]
        public DateTime? Paid { get; set; }

        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("returned")]
        public DateTime? Returned { get; set; }
    }
}
