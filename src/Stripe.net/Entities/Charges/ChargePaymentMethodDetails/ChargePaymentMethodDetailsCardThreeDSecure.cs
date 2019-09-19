namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardThreeDSecure : StripeEntity<ChargePaymentMethodDetailsCardThreeDSecure>
    {
        /// <summary>
        /// Whether or not authentication was performed. 3D Secure will succeed without
        /// authentication when the card is not enrolled.
        /// </summary>
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        /// <summary>
        /// Whether or not 3D Secure succeeded.
        /// </summary>
        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        /// <summary>
        /// The version of 3D Secure that was used for this payment.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
