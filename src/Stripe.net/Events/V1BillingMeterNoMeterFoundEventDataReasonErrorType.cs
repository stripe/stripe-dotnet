// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V1BillingMeterNoMeterFoundEventDataReasonErrorType : StripeEntity<V1BillingMeterNoMeterFoundEventDataReasonErrorType>
    {
        /// <summary>
        /// Open Enum.
        /// One of: <c>archived_meter</c>, <c>meter_event_customer_not_found</c>,
        /// <c>meter_event_dimension_count_too_high</c>, <c>meter_event_invalid_value</c>,
        /// <c>meter_event_no_customer_defined</c>, <c>missing_dimension_payload_keys</c>,
        /// <c>no_meter</c>, <c>timestamp_in_future</c>, or <c>timestamp_too_far_in_past</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif

        public string Code { get; set; }

        /// <summary>
        /// The number of errors of this type.
        /// </summary>
        [JsonProperty("error_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_count")]
#endif

        public long ErrorCount { get; set; }

        /// <summary>
        /// A list of sample errors of this type.
        /// </summary>
        [JsonProperty("sample_errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sample_errors")]
#endif

        public List<V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleError> SampleErrors { get; set; }
    }
}
