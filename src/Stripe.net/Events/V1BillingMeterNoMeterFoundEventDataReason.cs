// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class V1BillingMeterNoMeterFoundEventDataReason : StripeEntity<V1BillingMeterNoMeterFoundEventDataReason>
    {
        /// <summary>
        /// The total error count within this window.
        /// </summary>
        [JsonProperty("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// The error details.
        /// </summary>
        [JsonProperty("error_types")]
        public List<V1BillingMeterNoMeterFoundEventDataReasonErrorType> ErrorTypes { get; set; }
    }
}
