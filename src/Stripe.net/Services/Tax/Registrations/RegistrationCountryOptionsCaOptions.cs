// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationCountryOptionsCaOptions : INestedOptions
    {
        /// <summary>
        /// Options for the provincial tax registration.
        /// </summary>
        [JsonProperty("province_standard")]
        [STJS.JsonPropertyName("province_standard")]
        public RegistrationCountryOptionsCaProvinceStandardOptions ProvinceStandard { get; set; }

        /// <summary>
        /// Type of registration to be created in Canada.
        /// One of: <c>province_standard</c>, <c>simplified</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
