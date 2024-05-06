// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferTrackingDetailsAch : StripeEntity<OutboundTransferTrackingDetailsAch>
    {
        /// <summary>
        /// ACH trace ID of the OutboundTransfer for transfers sent over the <c>ach</c> network.
        /// </summary>
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }
    }
}
