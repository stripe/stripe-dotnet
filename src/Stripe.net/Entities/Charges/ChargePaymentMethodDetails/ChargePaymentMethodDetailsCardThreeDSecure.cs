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
        /// For authenticated transactions: whether issuing bank authenticated the cardholder with a
        /// traditional challenge screen, or with device data via the 3DS2 frictionless flow. One of
        /// <c>challenge</c> or <c>frictionless</c>.
        /// </summary>
        [JsonProperty("authentication_flow")]
        public string AuthenticationFlow { get; set; }

        /// <summary>
        /// Indicates the outcome of 3D Secure authentication.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// Additional information about why 3D Secure succeeded or failed.
        /// </summary>
        [JsonProperty("result_reason")]
        public string ResultReason { get; set; }

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
