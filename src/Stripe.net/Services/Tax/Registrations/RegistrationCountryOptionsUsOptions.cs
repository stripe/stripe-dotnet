// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsOptions : INestedOptions
    {
        /// <summary>
        /// Options for the local amusement tax registration.
        /// </summary>
        [JsonProperty("local_amusement_tax")]
        public RegistrationCountryOptionsUsLocalAmusementTaxOptions LocalAmusementTax { get; set; }

        /// <summary>
        /// Options for the local lease tax registration.
        /// </summary>
        [JsonProperty("local_lease_tax")]
        public RegistrationCountryOptionsUsLocalLeaseTaxOptions LocalLeaseTax { get; set; }

        /// <summary>
        /// Two-letter US state code (<a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO
        /// 3166-2</a>).
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Type of registration to be created in the US.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
