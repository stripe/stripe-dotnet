// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodCardNetworks : StripeEntity<PaymentMethodCardNetworks>
    {
        /// <summary>
        /// All networks available for selection via <a
        /// href="https://stripe.com/api/payment_intents/confirm#confirm_payment_intent-payment_method_options-card-network">payment_method_options.card.network</a>.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public List<string> Available { get; set; }

        /// <summary>
        /// The preferred network for co-branded cards. Can be <c>cartes_bancaires</c>,
        /// <c>mastercard</c>, <c>visa</c> or <c>invalid_preference</c> if requested network is not
        /// valid for the card.
        /// </summary>
        [JsonProperty("preferred")]
        [STJS.JsonPropertyName("preferred")]
        public string Preferred { get; set; }
    }
}
