namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardThreeDSecureUsage : StripeEntity<PaymentMethodCardThreeDSecureUsage>
    {
        /// <summary>
        /// Whether 3D Secure is supported on this card.
        /// </summary>
        [JsonProperty("supported")]
        public bool Supported { get; set; }
    }
}
