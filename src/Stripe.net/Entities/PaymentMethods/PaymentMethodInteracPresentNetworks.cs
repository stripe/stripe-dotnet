// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodInteracPresentNetworks : StripeEntity<PaymentMethodInteracPresentNetworks>
    {
        /// <summary>
        /// All networks available for selection via <a
        /// href="https://stripe.com/api/payment_intents/confirm#confirm_payment_intent-payment_method_options-card-network">payment_method_options.card.network</a>.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public List<string> Available { get; set; }

        /// <summary>
        /// The preferred network for the card.
        /// </summary>
        [JsonProperty("preferred")]
        [STJS.JsonPropertyName("preferred")]
        public string Preferred { get; set; }
    }
}
