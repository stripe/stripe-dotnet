// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2PaymentsSettlementAllocationIntentErroredEventData : StripeEntity<V2PaymentsSettlementAllocationIntentErroredEventData>
    {
        /// <summary>
        /// Stripe doc link to debug the issue.
        /// </summary>
        [JsonProperty("doc_url")]
        [STJS.JsonPropertyName("doc_url")]
        public string DocUrl { get; set; }

        /// <summary>
        /// User Message detailing the reason code and possible resolution .
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Open Enum. The <c>errored</c> status reason.
        /// One of: <c>amount_mismatch</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason_code")]
        [STJS.JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }
    }
}
