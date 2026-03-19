// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundTransferTrackingDetailsAch : StripeEntity<OutboundTransferTrackingDetailsAch>
    {
        /// <summary>
        /// ACH trace ID of the OutboundTransfer for transfers sent over the <c>ach</c> network.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
