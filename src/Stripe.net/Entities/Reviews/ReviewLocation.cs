namespace Stripe
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class ReviewLocation : StripeEntity<ReviewLocation>
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

        [JsonProperty("latitude")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latitude")]
#endif
        public decimal? Latitude { get; set; }

        [JsonProperty("longitude")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("longitude")]
#endif
        public decimal? Longitude { get; set; }

        [JsonProperty("region")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("region")]
#endif
        public string Region { get; set; }
    }
}
