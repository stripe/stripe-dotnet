// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsCaProvinceStandardOptions : INestedOptions
    {
        /// <summary>
        /// Two-letter CA province code (<a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO
        /// 3166-2</a>).
        /// </summary>
        [JsonProperty("province")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("province")]
#endif

        public string Province { get; set; }
    }
}
