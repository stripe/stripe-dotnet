// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodCardNetworks : StripeEntity<PaymentMethodCardNetworks>
    {
        /// <summary>
        /// All available networks for the card.
        /// </summary>
        [JsonProperty("available")]
        public List<string> Available { get; set; }

        /// <summary>
        /// The preferred network for the card. Will contain invalid_preference if requested network
        /// is not valid for the card.
        /// </summary>
        [JsonProperty("preferred")]
        public string Preferred { get; set; }
    }
}
