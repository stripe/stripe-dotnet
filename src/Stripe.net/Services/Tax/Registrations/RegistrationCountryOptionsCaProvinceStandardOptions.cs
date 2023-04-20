// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsCaProvinceStandardOptions : INestedOptions
    {
        /// <summary>
        /// Two-letter CA province code (<a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO
        /// 3166-2</a>).
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
    }
}
