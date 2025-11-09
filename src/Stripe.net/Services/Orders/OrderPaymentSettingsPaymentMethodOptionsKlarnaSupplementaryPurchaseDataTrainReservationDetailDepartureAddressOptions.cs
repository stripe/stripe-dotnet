// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailDepartureAddressOptions : INestedOptions
    {
        /// <summary>
        /// The city or town.
        /// </summary>
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

        /// <summary>
        /// The country in ISO 3166-1 alpha-2 format.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The postal code formatted according to country.
        /// </summary>
        [JsonProperty("postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("postal_code")]
#endif
        public string PostalCode { get; set; }

        /// <summary>
        /// The state, county, province, or region formatted according to country.
        /// </summary>
        [JsonProperty("region")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("region")]
#endif
        public string Region { get; set; }

        /// <summary>
        /// Line 1 of the street address.
        /// </summary>
        [JsonProperty("street_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("street_address")]
#endif
        public string StreetAddress { get; set; }

        /// <summary>
        /// Line 2 of the street address.
        /// </summary>
        [JsonProperty("street_address2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("street_address2")]
#endif
        public string StreetAddress2 { get; set; }
    }
}
