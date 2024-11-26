// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsUsOptions : INestedOptions
    {
        /// <summary>
        /// Options for the local amusement tax registration.
        /// </summary>
        [JsonProperty("local_amusement_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local_amusement_tax")]
#endif
        public RegistrationCountryOptionsUsLocalAmusementTaxOptions LocalAmusementTax { get; set; }

        /// <summary>
        /// Options for the local lease tax registration.
        /// </summary>
        [JsonProperty("local_lease_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local_lease_tax")]
#endif
        public RegistrationCountryOptionsUsLocalLeaseTaxOptions LocalLeaseTax { get; set; }

        /// <summary>
        /// Two-letter US state code (<a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO
        /// 3166-2</a>).
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// Options for the state sales tax registration.
        /// </summary>
        [JsonProperty("state_sales_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state_sales_tax")]
#endif
        public RegistrationCountryOptionsUsStateSalesTaxOptions StateSalesTax { get; set; }

        /// <summary>
        /// Type of registration to be created in the US.
        /// One of: <c>local_amusement_tax</c>, <c>local_lease_tax</c>,
        /// <c>state_communications_tax</c>, <c>state_retail_delivery_fee</c>, or
        /// <c>state_sales_tax</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
