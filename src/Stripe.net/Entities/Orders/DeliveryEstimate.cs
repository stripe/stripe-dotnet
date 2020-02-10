namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DeliveryEstimate : StripeEntity<DeliveryEstimate>
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
