// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsJpStandardOptions : INestedOptions
    {
        /// <summary>
        /// Place of supply scheme used in an standard registration.
        /// One of: <c>inbound_goods</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("place_of_supply_scheme")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("place_of_supply_scheme")]
#endif
        public string PlaceOfSupplyScheme { get; set; }
    }
}
