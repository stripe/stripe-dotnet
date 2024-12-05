// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferTrackingDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// ACH trace ID for funds sent over the <c>ach</c> network.
        /// </summary>
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }
    }
}
