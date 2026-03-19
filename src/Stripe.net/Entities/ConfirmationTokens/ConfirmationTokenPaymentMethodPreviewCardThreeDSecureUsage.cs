// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodPreviewCardThreeDSecureUsage : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardThreeDSecureUsage>
    {
        /// <summary>
        /// Whether 3D Secure is supported on this card.
        /// </summary>
        [JsonProperty("supported")]
        [STJS.JsonPropertyName("supported")]
        public bool Supported { get; set; }
    }
}
