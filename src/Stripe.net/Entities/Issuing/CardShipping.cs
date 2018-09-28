namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardShipping : StripeEntity
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("eta")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Eta { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
