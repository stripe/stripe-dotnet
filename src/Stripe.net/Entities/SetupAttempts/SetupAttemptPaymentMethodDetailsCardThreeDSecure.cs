// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupAttemptPaymentMethodDetailsCardThreeDSecure : StripeEntity<SetupAttemptPaymentMethodDetailsCardThreeDSecure>
    {
        /// <summary>
        /// For authenticated transactions: how the customer was authenticated by the issuing bank.
        /// One of: <c>challenge</c>, or <c>frictionless</c>.
        /// </summary>
        [JsonProperty("authentication_flow")]
        public string AuthenticationFlow { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI). A protocol-level field indicating what degree
        /// of authentication was performed.
        /// One of: <c>01</c>, <c>02</c>, <c>05</c>, <c>06</c>, or <c>07</c>.
        /// </summary>
        [JsonProperty("electronic_commerce_indicator")]
        public string ElectronicCommerceIndicator { get; set; }

        /// <summary>
        /// Indicates the outcome of 3D Secure authentication.
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, <c>exempted</c>,
        /// <c>failed</c>, <c>not_supported</c>, or <c>processing_error</c>.
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
        /// The 3D Secure 1 XID or 3D Secure 2 Directory Server Transaction ID (dsTransId) for this
        /// payment.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// The version of 3D Secure that was used.
        /// One of: <c>1.0.2</c>, <c>2.1.0</c>, or <c>2.2.0</c>.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
