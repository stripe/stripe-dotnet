// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RegistrationCountryOptionsUsStateSalesTax : StripeEntity<RegistrationCountryOptionsUsStateSalesTax>
    {
        /// <summary>
        /// Elections for the state sales tax registration.
        /// </summary>
        [JsonProperty("elections")]
        [STJS.JsonPropertyName("elections")]
        public List<RegistrationCountryOptionsUsStateSalesTaxElection> Elections { get; set; }
    }
}
