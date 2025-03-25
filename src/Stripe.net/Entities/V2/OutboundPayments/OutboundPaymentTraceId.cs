// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentTraceId : StripeEntity<OutboundPaymentTraceId>
    {
        /// <summary>
        /// Possible values are <c>pending</c>, <c>supported</c>, and <c>unsupported</c>. Initially
        /// set to <c>pending</c>, it changes to <c>supported</c> when the recipient bank provides a
        /// trace ID, or <c>unsupported</c> if the recipient bank doesn't support it. Note that this
        /// status may not align with the OutboundPayment or OutboundTransfer status and can remain
        /// <c>pending</c> even after the payment or transfer is posted.
        /// One of: <c>pending</c>, <c>supported</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The trace ID value if <c>trace_id.status</c> is <c>supported</c>, otherwise empty.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
