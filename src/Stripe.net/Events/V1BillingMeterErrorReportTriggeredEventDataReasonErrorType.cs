// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V1BillingMeterErrorReportTriggeredEventDataReasonErrorType : StripeEntity<V1BillingMeterErrorReportTriggeredEventDataReasonErrorType>
    {
        /// <summary>
        /// Open Enum.
        /// One of: <c>archived_meter</c>, <c>meter_event_customer_not_found</c>,
        /// <c>meter_event_dimension_count_too_high</c>, <c>meter_event_invalid_value</c>,
        /// <c>meter_event_no_customer_defined</c>, <c>missing_dimension_payload_keys</c>,
        /// <c>no_meter</c>, <c>timestamp_in_future</c>, or <c>timestamp_too_far_in_past</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The number of errors of this type.
        /// </summary>
        [JsonProperty("error_count")]
        [STJS.JsonPropertyName("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// A list of sample errors of this type.
        /// </summary>
        [JsonProperty("sample_errors")]
        [STJS.JsonPropertyName("sample_errors")]
        public List<V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleError> SampleErrors { get; set; }
    }
}
