// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterErrorReportReasonErrorTypeSampleError : StripeEntity<MeterErrorReportReasonErrorTypeSampleError>
    {
        [JsonProperty("api_request")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("api_request")]
#endif
        public MeterErrorReportReasonErrorTypeSampleErrorApiRequest ApiRequest { get; set; }

        /// <summary>
        /// message of the error.
        /// </summary>
        [JsonProperty("error_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_message")]
#endif
        public string ErrorMessage { get; set; }
    }
}
