// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using Newtonsoft.Json;

    public class SupplierLocation : StripeEntity<SupplierLocation>
    {
        /// <summary>
        /// The city where the supplier is located.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country where the supplier is located.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The geographic latitude where the supplier is located.
        /// </summary>
        [JsonProperty("latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// The geographic longitude where the supplier is located.
        /// </summary>
        [JsonProperty("longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// The state/county/province/region where the supplier is located.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
