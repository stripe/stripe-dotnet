// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterErrorReportReasonErrorTypeSampleError : StripeEntity<MeterErrorReportReasonErrorTypeSampleError>
    {
        [JsonProperty("api_request")]
        public MeterErrorReportReasonErrorTypeSampleErrorApiRequest ApiRequest { get; set; }

        /// <summary>
        /// message of the error.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}
