// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsCardThreeDSecureOptions : INestedOptions
    {
        /// <summary>
        /// For authenticated transactions: Indicates how the issuing bank authenticated the
        /// customer.
        /// One of: <c>challenge</c>, or <c>frictionless</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("authentication_flow")]
        [STJS.JsonPropertyName("authentication_flow")]
        public string AuthenticationFlow { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI). A protocol-level field indicating what degree
        /// of authentication was performed.
        /// One of: <c>01</c>, <c>02</c>, <c>05</c>, <c>06</c>, or <c>07</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("electronic_commerce_indicator")]
        [STJS.JsonPropertyName("electronic_commerce_indicator")]
        public string ElectronicCommerceIndicator { get; set; }

        /// <summary>
        /// The exemption requested via 3DS and accepted by the issuer at authentication time.
        /// One of: <c>low_risk</c>, or <c>none</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("exemption_indicator")]
        [STJS.JsonPropertyName("exemption_indicator")]
        public string ExemptionIndicator { get; set; }

        /// <summary>
        /// Indicates the outcome of 3D Secure authentication.
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, or <c>exempted</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// The version of 3D Secure that was used.
        /// One of: <c>1.0.2</c>, <c>2.1.0</c>, <c>2.2.0</c>, <c>2.3.0</c>, or <c>2.3.1</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
