// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewCardNetworks : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardNetworks>
    {
        /// <summary>
        /// All networks available for selection via <a
        /// href="https://stripe.com/api/payment_intents/confirm#confirm_payment_intent-payment_method_options-card-network">payment_method_options.card.network</a>.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public List<string> Available { get; set; }

        /// <summary>
        /// The preferred network for co-branded cards. Can be <c>cartes_bancaires</c>,
        /// <c>mastercard</c>, <c>visa</c> or <c>invalid_preference</c> if requested network is not
        /// valid for the card.
        /// </summary>
        [JsonProperty("preferred")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred")]
#endif
        public string Preferred { get; set; }
    }
}
