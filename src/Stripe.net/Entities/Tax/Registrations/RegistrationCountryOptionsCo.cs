// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsCo : StripeEntity<RegistrationCountryOptionsCo>
    {
        /// <summary>
        /// Type of registration in <c>country</c>.
        /// One of: <c>simplified</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}