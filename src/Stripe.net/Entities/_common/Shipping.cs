namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class Shipping : StripeEntity<Shipping>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonProperty("carrier")]
        [STJS.JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonProperty("tracking_number")]
        [STJS.JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
