namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class Address : StripeEntity<Address>
    {
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("city")]
#else
        [JsonProperty("city")]
#endif
        public string City { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("country")]
#else
        [JsonProperty("country")]
#endif
        public string Country { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("line1")]
#else
        [JsonProperty("line1")]
#endif
        public string Line1 { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("line2")]
#else
        [JsonProperty("line2")]
#endif
        public string Line2 { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("postal_code")]
#else
        [JsonProperty("postal_code")]
#endif
        public string PostalCode { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("state")]
#else
        [JsonProperty("state")]
#endif
        public string State { get; set; }
    }
}
