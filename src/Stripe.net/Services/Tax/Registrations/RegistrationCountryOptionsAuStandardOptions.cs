// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationCountryOptionsAuStandardOptions : INestedOptions
    {
        /// <summary>
        /// Place of supply scheme used in an standard registration.
        /// One of: <c>inbound_goods</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("place_of_supply_scheme")]
        [STJS.JsonPropertyName("place_of_supply_scheme")]
        public string PlaceOfSupplyScheme { get; set; }
    }
}
