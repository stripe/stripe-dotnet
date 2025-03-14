// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterErrorReportReasonErrorType : StripeEntity<MeterErrorReportReasonErrorType>
    {
        [JsonProperty("sample_errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sample_errors")]
#endif
        public List<MeterErrorReportReasonErrorTypeSampleError> SampleErrors { get; set; }
    }
}
