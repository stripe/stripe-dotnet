namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AddressOptions : INestedOptions
    {
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        [JsonProperty("line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line1")]
#endif
        public string Line1 { get; set; }

        [JsonProperty("line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line2")]
#endif
        public string Line2 { get; set; }

        [JsonProperty("postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("postal_code")]
#endif
        public string PostalCode { get; set; }

        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }
    }
}
