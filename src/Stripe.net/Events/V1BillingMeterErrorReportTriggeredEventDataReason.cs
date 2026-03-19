// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V1BillingMeterErrorReportTriggeredEventDataReason : StripeEntity<V1BillingMeterErrorReportTriggeredEventDataReason>
    {
        /// <summary>
        /// The total error count within this window.
        /// </summary>
        [JsonProperty("error_count")]
        [STJS.JsonPropertyName("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// The error details.
        /// </summary>
        [JsonProperty("error_types")]
        [STJS.JsonPropertyName("error_types")]
        public List<V1BillingMeterErrorReportTriggeredEventDataReasonErrorType> ErrorTypes { get; set; }
    }
}
