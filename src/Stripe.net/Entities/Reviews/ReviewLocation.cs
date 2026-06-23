namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class ReviewLocation : StripeEntity<ReviewLocation>
    {
        [JsonProperty("city")]
        [STJS.JsonPropertyName("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("latitude")]
        [STJS.JsonPropertyName("latitude")]
        public decimal? Latitude { get; set; }

        [JsonProperty("longitude")]
        [STJS.JsonPropertyName("longitude")]
        public decimal? Longitude { get; set; }

        [JsonProperty("region")]
        [STJS.JsonPropertyName("region")]
        public string Region { get; set; }
    }
}
