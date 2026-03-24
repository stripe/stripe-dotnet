// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RegistrationCountryOptionsUsEntertainmentTax : StripeEntity<RegistrationCountryOptionsUsEntertainmentTax>
    {
        /// <summary>
        /// A <a
        /// href="https://docs.stripe.com/tax/registering?type=entertainment_tax#registration-types">jurisdiction
        /// code</a> representing the local jurisdiction.
        /// </summary>
        [JsonProperty("jurisdiction")]
        [STJS.JsonPropertyName("jurisdiction")]
        public string Jurisdiction { get; set; }
    }
}
