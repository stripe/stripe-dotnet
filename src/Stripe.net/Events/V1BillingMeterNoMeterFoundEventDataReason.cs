// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V1BillingMeterNoMeterFoundEventDataReason : StripeEntity<V1BillingMeterNoMeterFoundEventDataReason>
    {
        /// <summary>
        /// The total error count within this window.
        /// </summary>
        [JsonProperty("error_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_count")]
#endif
        public long ErrorCount { get; set; }

        /// <summary>
        /// The error details.
        /// </summary>
        [JsonProperty("error_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_types")]
#endif
        public List<V1BillingMeterNoMeterFoundEventDataReasonErrorType> ErrorTypes { get; set; }
    }
}
