// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderDeliveryDetailLocation : StripeEntity<OrderDeliveryDetailLocation>
    {
        /// <summary>
        /// The city where the supplier is located.
        /// </summary>
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country where the supplier is located.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The geographic latitude where the supplier is located.
        /// </summary>
        [JsonProperty("latitude")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latitude")]
#endif
        public decimal? Latitude { get; set; }

        /// <summary>
        /// The geographic longitude where the supplier is located.
        /// </summary>
        [JsonProperty("longitude")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("longitude")]
#endif
        public decimal? Longitude { get; set; }

        /// <summary>
        /// The state/county/province/region where the supplier is located.
        /// </summary>
        [JsonProperty("region")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("region")]
#endif
        public string Region { get; set; }
    }
}
