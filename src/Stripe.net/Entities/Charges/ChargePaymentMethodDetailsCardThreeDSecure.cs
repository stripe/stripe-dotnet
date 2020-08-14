namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardThreeDSecure : StripeEntity<ChargePaymentMethodDetailsCardThreeDSecure>
    {
        /// <summary>
        /// Whether or not authentication was performed. 3D Secure will succeed without
        /// authentication when the card is not enrolled.
        /// </summary>
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        /// <summary>
        /// For authenticated transactions: how the customer was authenticated by the issuing bank.
        /// One of: <c>challenge</c>, or <c>frictionless</c>.
        /// </summary>
        [JsonProperty("authentication_flow")]
        public string AuthenticationFlow { get; set; }

        /// <summary>
        /// Indicates the outcome of 3D Secure authentication.
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, <c>failed</c>,
        /// <c>not_supported</c>, or <c>processing_error</c>.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// Additional information about why 3D Secure succeeded or failed based on the
        /// <c>result</c>.
        /// One of: <c>abandoned</c>, <c>bypassed</c>, <c>canceled</c>, <c>card_not_enrolled</c>,
        /// <c>network_not_supported</c>, <c>protocol_error</c>, or <c>rejected</c>.
        /// </summary>
        [JsonProperty("result_reason")]
        public string ResultReason { get; set; }

        /// <summary>
        /// Whether or not 3D Secure succeeded.
        /// </summary>
        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        /// <summary>
        /// The version of 3D Secure that was used.
        /// One of: <c>1.0.2</c>, <c>2.1.0</c>, or <c>2.2.0</c>.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
