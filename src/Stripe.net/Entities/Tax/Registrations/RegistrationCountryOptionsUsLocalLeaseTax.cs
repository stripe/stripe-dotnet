// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsLocalLeaseTax : StripeEntity<RegistrationCountryOptionsUsLocalLeaseTax>
    {
        /// <summary>
        /// A FIPS/GNIS code representing the local jurisdiction.
        /// </summary>
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }
    }
}
