namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class Shipping : StripeEntity<Shipping>
    {
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        [JsonProperty("carrier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier")]
#endif
        public string Carrier { get; set; }

        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        [JsonProperty("tracking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tracking_number")]
#endif
        public string TrackingNumber { get; set; }
    }
}
