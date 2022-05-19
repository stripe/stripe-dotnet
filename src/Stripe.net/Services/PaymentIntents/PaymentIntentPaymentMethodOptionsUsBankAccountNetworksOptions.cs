// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsUsBankAccountNetworksOptions : INestedOptions
    {
        /// <summary>
        /// Triggers validations to run across the selected networks.
        /// </summary>
        [JsonProperty("requested")]
        public List<string> Requested { get; set; }
    }
}
