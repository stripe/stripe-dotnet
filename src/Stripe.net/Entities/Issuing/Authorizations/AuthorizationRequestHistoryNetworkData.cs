// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationRequestHistoryNetworkData : StripeEntity<AuthorizationRequestHistoryNetworkData>
    {
        /// <summary>
        /// Mastercard identifier for each authorization request.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public AuthorizationRequestHistoryNetworkDataTraceId TraceId { get; set; }
    }
}
