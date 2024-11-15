// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsUsStateSalesTaxOptions : INestedOptions
    {
        /// <summary>
        /// Elections for the state sales tax registration.
        /// </summary>
        [JsonProperty("elections")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("elections")]
#endif

        public List<RegistrationCountryOptionsUsStateSalesTaxElectionOptions> Elections { get; set; }
    }
}
