// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunStatusDetails : StripeEntity<ReportRunStatusDetails>
    {
        /// <summary>
        /// Error code categorizing the reason the <c>ReportRun</c> failed.
        /// One of: <c>file_size_above_limit</c>, or <c>internal_error</c>.
        /// </summary>
        [JsonProperty("error_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_code")]
#endif
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message with additional details about the failure.
        /// </summary>
        [JsonProperty("error_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_message")]
#endif
        public string ErrorMessage { get; set; }
    }
}
