// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsUsBankAccountNetworksOptions : INestedOptions
    {
        /// <summary>
        /// Triggers validations to run across the selected networks.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("requested")]
        public List<string> Requested { get; set; }
    }
}
