// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterErrorReportReason : StripeEntity<MeterErrorReportReason>
    {
        /// <summary>
        /// The number of errors generated.
        /// </summary>
        [JsonProperty("error_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_count")]
#endif
        public long ErrorCount { get; set; }

        /// <summary>
        /// More information about errors.
        /// </summary>
        [JsonProperty("error_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_types")]
#endif
        public List<MeterErrorReportReasonErrorType> ErrorTypes { get; set; }
    }
}
