// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationCountryOptionsUsStateSalesTaxOptions : INestedOptions
    {
        /// <summary>
        /// Elections for the state sales tax registration.
        /// </summary>
        [JsonProperty("elections")]
        [STJS.JsonPropertyName("elections")]
        public List<RegistrationCountryOptionsUsStateSalesTaxElectionOptions> Elections { get; set; }
    }
}
