// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleError : StripeEntity<V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleError>
    {
        /// <summary>
        /// The error message.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request causes the error.
        /// </summary>
        [JsonProperty("request")]
        public V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleErrorRequest Request { get; set; }
    }
}
