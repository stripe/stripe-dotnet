// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MeterErrorReportReason : StripeEntity<MeterErrorReportReason>
    {
        /// <summary>
        /// The number of errors generated.
        /// </summary>
        [JsonProperty("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// More information about errors.
        /// </summary>
        [JsonProperty("error_types")]
        public List<MeterErrorReportReasonErrorType> ErrorTypes { get; set; }
    }
}
