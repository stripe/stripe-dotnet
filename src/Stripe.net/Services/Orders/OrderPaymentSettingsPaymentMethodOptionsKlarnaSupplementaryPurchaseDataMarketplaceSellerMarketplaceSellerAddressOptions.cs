// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataMarketplaceSellerMarketplaceSellerAddressOptions : INestedOptions
    {
        /// <summary>
        /// The city or town.
        /// </summary>
        [JsonProperty("city")]
        [STJS.JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// The country in ISO 3166-1 alpha-2 format.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The postal code formatted according to country.
        /// </summary>
        [JsonProperty("postal_code")]
        [STJS.JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state, county, province, or region formatted according to country.
        /// </summary>
        [JsonProperty("region")]
        [STJS.JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// Line 1 of the street address.
        /// </summary>
        [JsonProperty("street_address")]
        [STJS.JsonPropertyName("street_address")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Line 2 of the street address.
        /// </summary>
        [JsonProperty("street_address2")]
        [STJS.JsonPropertyName("street_address2")]
        public string StreetAddress2 { get; set; }
    }
}
