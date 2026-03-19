// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsCardThreeDSecure : StripeEntity<PaymentRecordPaymentMethodDetailsCardThreeDSecure>
    {
        /// <summary>
        /// For authenticated transactions: Indicates how the issuing bank authenticated the
        /// customer.
        /// One of: <c>challenge</c>, or <c>frictionless</c>.
        /// </summary>
        [JsonProperty("authentication_flow")]
        [STJS.JsonPropertyName("authentication_flow")]
        public string AuthenticationFlow { get; set; }

        /// <summary>
        /// The 3D Secure cryptogram, also known as the "authentication value" (AAV, CAVV or AEVV).
        /// </summary>
        [JsonProperty("cryptogram")]
        [STJS.JsonPropertyName("cryptogram")]
        public string Cryptogram { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI). A protocol-level field indicating what degree
        /// of authentication was performed.
        /// One of: <c>01</c>, <c>02</c>, <c>03</c>, <c>04</c>, <c>05</c>, <c>06</c>, or <c>07</c>.
        /// </summary>
        [JsonProperty("electronic_commerce_indicator")]
        [STJS.JsonPropertyName("electronic_commerce_indicator")]
        public string ElectronicCommerceIndicator { get; set; }

        /// <summary>
        /// The exemption requested via 3DS and accepted by the issuer at authentication time.
        /// One of: <c>low_risk</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("exemption_indicator")]
        [STJS.JsonPropertyName("exemption_indicator")]
        public string ExemptionIndicator { get; set; }

        /// <summary>
        /// Whether Stripe requested the value of <c>exemption_indicator</c> in the transaction.
        /// This will depend on the outcome of Stripe's internal risk assessment.
        /// </summary>
        [JsonProperty("exemption_indicator_applied")]
        [STJS.JsonPropertyName("exemption_indicator_applied")]
        public bool? ExemptionIndicatorApplied { get; set; }

        /// <summary>
        /// Indicates the outcome of 3D Secure authentication.
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, <c>exempted</c>,
        /// <c>failed</c>, <c>not_supported</c>, or <c>processing_error</c>.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// Additional information about why 3D Secure succeeded or failed, based on the
        /// <c>result</c>.
        /// One of: <c>abandoned</c>, <c>bypassed</c>, <c>canceled</c>, <c>card_not_enrolled</c>,
        /// <c>network_not_supported</c>, <c>protocol_error</c>, or <c>rejected</c>.
        /// </summary>
        [JsonProperty("result_reason")]
        [STJS.JsonPropertyName("result_reason")]
        public string ResultReason { get; set; }

        /// <summary>
        /// The version of 3D Secure that was used.
        /// One of: <c>1.0.2</c>, <c>2.1.0</c>, or <c>2.2.0</c>.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
