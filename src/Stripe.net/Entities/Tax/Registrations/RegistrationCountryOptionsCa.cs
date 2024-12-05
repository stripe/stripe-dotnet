// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsCa : StripeEntity<RegistrationCountryOptionsCa>
    {
        [JsonProperty("province_standard")]
        public RegistrationCountryOptionsCaProvinceStandard ProvinceStandard { get; set; }

        /// <summary>
        /// Type of registration in Canada.
        /// One of: <c>province_standard</c>, <c>simplified</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
