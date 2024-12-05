// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsNo : StripeEntity<RegistrationCountryOptionsNo>
    {
        /// <summary>
        /// Type of registration in <c>country</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
