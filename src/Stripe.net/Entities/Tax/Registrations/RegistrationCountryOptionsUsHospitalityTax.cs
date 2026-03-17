// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsUsHospitalityTax : StripeEntity<RegistrationCountryOptionsUsHospitalityTax>
    {
        /// <summary>
        /// A <a
        /// href="https://docs.stripe.com/tax/registering?type=hospitality_tax#registration-types">jurisdiction
        /// code</a> representing the local jurisdiction.
        /// </summary>
        [JsonProperty("jurisdiction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction")]
#endif
        public string Jurisdiction { get; set; }
    }
}
