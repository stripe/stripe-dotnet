// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentTrackingDetailsAch : StripeEntity<OutboundPaymentTrackingDetailsAch>
    {
        /// <summary>
        /// ACH trace ID of the OutboundPayment for payments sent over the <c>ach</c> network.
        /// </summary>
        [JsonProperty("trace_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trace_id")]
#endif
        public string TraceId { get; set; }
    }
}
