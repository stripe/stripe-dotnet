using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeStatusTransitions : StripeEntity
    {
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("canceled")]
        public DateTime? Canceled { get; set; }

        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("fulfilled")]
        public DateTime? Fulfilled { get; set; }

        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("paid")]
        public DateTime? Paid { get; set; }

        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("returned")]
        public DateTime? Returned { get; set; }
    }
}
