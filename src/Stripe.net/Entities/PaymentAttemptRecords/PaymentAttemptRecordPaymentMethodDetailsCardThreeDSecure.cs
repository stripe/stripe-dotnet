// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsCardThreeDSecure : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCardThreeDSecure>
    {
        /// <summary>
        /// One of: <c>challenge</c>, or <c>frictionless</c>.
        /// </summary>
        [JsonProperty("authentication_flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authentication_flow")]
#endif
        public string AuthenticationFlow { get; set; }

        /// <summary>
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, <c>exempted</c>,
        /// <c>failed</c>, <c>not_supported</c>, or <c>processing_error</c>.
        /// </summary>
        [JsonProperty("result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result")]
#endif
        public string Result { get; set; }

        /// <summary>
        /// One of: <c>abandoned</c>, <c>bypassed</c>, <c>canceled</c>, <c>card_not_enrolled</c>,
        /// <c>network_not_supported</c>, <c>protocol_error</c>, or <c>rejected</c>.
        /// </summary>
        [JsonProperty("result_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result_reason")]
#endif
        public string ResultReason { get; set; }

        /// <summary>
        /// One of: <c>1.0.2</c>, <c>2.1.0</c>, or <c>2.2.0</c>.
        /// </summary>
        [JsonProperty("version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("version")]
#endif
        public string Version { get; set; }
    }
}
