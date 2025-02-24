// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodCardPresentNetworks : StripeEntity<PaymentMethodCardPresentNetworks>
    {
        /// <summary>
        /// All networks available for selection via <a
        /// href="https://stripe.com/api/payment_intents/confirm#confirm_payment_intent-payment_method_options-card-network">payment_method_options.card.network</a>.
        /// </summary>
        [JsonProperty("available")]
        public List<string> Available { get; set; }

        /// <summary>
        /// The preferred network for the card.
        /// </summary>
        [JsonProperty("preferred")]
        public string Preferred { get; set; }
    }
}
