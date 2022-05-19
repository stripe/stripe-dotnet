// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodUsBankAccountNetworks : StripeEntity<PaymentMethodUsBankAccountNetworks>
    {
        /// <summary>
        /// The preferred network.
        /// </summary>
        [JsonProperty("preferred")]
        public string Preferred { get; set; }

        /// <summary>
        /// All supported networks.
        /// </summary>
        [JsonProperty("supported")]
        public List<string> Supported { get; set; }
    }
}
