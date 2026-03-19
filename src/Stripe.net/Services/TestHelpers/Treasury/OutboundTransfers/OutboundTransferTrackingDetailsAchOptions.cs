// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferTrackingDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// ACH trace ID for funds sent over the <c>ach</c> network.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
