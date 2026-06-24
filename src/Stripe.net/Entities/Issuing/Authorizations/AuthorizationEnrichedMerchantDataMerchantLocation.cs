// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantDataMerchantLocation : StripeEntity<AuthorizationEnrichedMerchantDataMerchantLocation>
    {
        /// <summary>
        /// Address details of the seller.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AuthorizationEnrichedMerchantDataMerchantLocationAddress Address { get; set; }

        /// <summary>
        /// Coordinates of the seller.
        /// </summary>
        [JsonProperty("coordinates")]
        [STJS.JsonPropertyName("coordinates")]
        public AuthorizationEnrichedMerchantDataMerchantLocationCoordinates Coordinates { get; set; }
    }
}
