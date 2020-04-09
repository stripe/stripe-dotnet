namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReviewLocation : StripeEntity<ReviewLocation>
    {
        /// <summary>
        /// The city where the payment originated.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country where the payment originated.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The geographic latitude where the payment originated.
        /// </summary>
        [JsonProperty("latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// The geographic longitude where the payment originated.
        /// </summary>
        [JsonProperty("longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// The state/county/province/region where the payment originated.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
