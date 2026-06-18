// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantDataMerchantLocationCoordinates : StripeEntity<AuthorizationEnrichedMerchantDataMerchantLocationCoordinates>
    {
        /// <summary>
        /// Latitude of the seller's location.
        /// </summary>
        [JsonProperty("latitude")]
        [STJS.JsonPropertyName("latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Longitude of the seller's location.
        /// </summary>
        [JsonProperty("longitude")]
        [STJS.JsonPropertyName("longitude")]
        public decimal? Longitude { get; set; }
    }
}
