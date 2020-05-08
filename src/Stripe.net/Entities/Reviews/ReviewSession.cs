namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReviewSession : StripeEntity<ReviewSession>
    {
        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
