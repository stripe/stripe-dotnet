// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsCaOptions : INestedOptions
    {
        /// <summary>
        /// Options for the provincial tax registration.
        /// </summary>
        [JsonProperty("province_standard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("province_standard")]
#endif
        public RegistrationCountryOptionsCaProvinceStandardOptions ProvinceStandard { get; set; }

        /// <summary>
        /// Type of registration to be created in Canada.
        /// One of: <c>province_standard</c>, <c>simplified</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
