// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewCardNetworks : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardNetworks>
    {
        /// <summary>
        /// All networks available for selection via <a
        /// href="https://stripe.com/api/payment_intents/confirm#confirm_payment_intent-payment_method_options-card-network">payment_method_options.card.network</a>.
        /// </summary>
        [JsonProperty("available")]
        public List<string> Available { get; set; }

        /// <summary>
        /// The preferred network for co-branded cards. Can be <c>cartes_bancaires</c>,
        /// <c>mastercard</c>, <c>visa</c> or <c>invalid_preference</c> if requested network is not
        /// valid for the card.
        /// </summary>
        [JsonProperty("preferred")]
        public string Preferred { get; set; }
    }
}
