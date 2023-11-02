// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsGrStandardOptions : INestedOptions
    {
        /// <summary>
        /// Place of supply scheme used in an EU standard registration.
        /// One of: <c>small_seller</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("place_of_supply_scheme")]
        public string PlaceOfSupplyScheme { get; set; }
    }
}
