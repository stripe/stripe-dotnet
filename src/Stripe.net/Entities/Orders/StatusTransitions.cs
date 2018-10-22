namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StatusTransitions : StripeEntity
    {
        [JsonProperty("canceled")]
        public DateTime? Canceled { get; set; }

        [JsonProperty("fulfiled")]
        public DateTime? Fulfiled { get; set; }

        [JsonProperty("paid")]
        public DateTime? Paid { get; set; }

        [JsonProperty("returned")]
        public DateTime? Returned { get; set; }
    }
}
