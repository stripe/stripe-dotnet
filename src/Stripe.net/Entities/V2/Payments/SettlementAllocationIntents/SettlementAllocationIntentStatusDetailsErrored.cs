// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettlementAllocationIntentStatusDetailsErrored : StripeEntity<SettlementAllocationIntentStatusDetailsErrored>
    {
        /// <summary>
        /// Stripe doc link to debug the issue.
        /// </summary>
        [JsonProperty("doc_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("doc_url")]
#endif
        public string DocUrl { get; set; }

        /// <summary>
        /// User Message detailing the reason code and possible resolution .
        /// </summary>
        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }

        /// <summary>
        /// Open Enum. The <c>errored</c> status reason.
        /// </summary>
        [JsonProperty("reason_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason_code")]
#endif
        public string ReasonCode { get; set; }
    }
}
