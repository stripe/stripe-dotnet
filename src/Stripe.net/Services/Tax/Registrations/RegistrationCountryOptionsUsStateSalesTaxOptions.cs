// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsStateSalesTaxOptions : INestedOptions
    {
        /// <summary>
        /// Elections for the state sales tax registration.
        /// </summary>
        [JsonProperty("elections")]
        public List<RegistrationCountryOptionsUsStateSalesTaxElectionOptions> Elections { get; set; }
    }
}
