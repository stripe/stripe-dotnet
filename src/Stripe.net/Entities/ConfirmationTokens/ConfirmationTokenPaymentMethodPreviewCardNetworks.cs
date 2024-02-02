// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewCardNetworks : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardNetworks>
    {
        /// <summary>
        /// All available networks for the card.
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
