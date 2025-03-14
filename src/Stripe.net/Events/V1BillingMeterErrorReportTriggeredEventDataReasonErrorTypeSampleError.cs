// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleError : StripeEntity<V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleError>
    {
        /// <summary>
        /// The error message.
        /// </summary>
        [JsonProperty("error_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_message")]
#endif
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request causes the error.
        /// </summary>
        [JsonProperty("request")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request")]
#endif
        public V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleErrorRequest Request { get; set; }
    }
}
