// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsRoStandard : StripeEntity<RegistrationCountryOptionsRoStandard>
    {
        /// <summary>
        /// Place of supply scheme used in an EU standard registration.
        /// One of: <c>small_seller</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("place_of_supply_scheme")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("place_of_supply_scheme")]
#endif
        public string PlaceOfSupplyScheme { get; set; }
    }
}
