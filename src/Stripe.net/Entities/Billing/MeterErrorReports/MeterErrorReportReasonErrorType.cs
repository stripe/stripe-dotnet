// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MeterErrorReportReasonErrorType : StripeEntity<MeterErrorReportReasonErrorType>
    {
        [JsonProperty("sample_errors")]
        public List<MeterErrorReportReasonErrorTypeSampleError> SampleErrors { get; set; }
    }
}
