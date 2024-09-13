namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class Shipping : StripeEntity<Shipping>
    {
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("address")]
#else
        [JsonProperty("address")]
#endif
        public Address Address { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("carrier")]
#else
        [JsonProperty("carrier")]
#endif
        public string Carrier { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("name")]
#else
        [JsonProperty("name")]
#endif
        public string Name { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("phone")]
#else
        [JsonProperty("phone")]
#endif
        public string Phone { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tracking_number")]
#else
        [JsonProperty("tracking_number")]
#endif
        public string TrackingNumber { get; set; }
    }
}
