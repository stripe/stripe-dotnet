// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsStateSalesTax : StripeEntity<RegistrationCountryOptionsUsStateSalesTax>
    {
        /// <summary>
        /// Elections for the state sales tax registration.
        /// </summary>
        [JsonProperty("elections")]
        public List<RegistrationCountryOptionsUsStateSalesTaxElection> Elections { get; set; }
    }
}
