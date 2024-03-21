// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewCardThreeDSecureUsage : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardThreeDSecureUsage>
    {
        /// <summary>
        /// Whether 3D Secure is supported on this card.
        /// </summary>
        [JsonProperty("supported")]
        public bool Supported { get; set; }
    }
}
