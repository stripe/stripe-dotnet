// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunStatusDetails : StripeEntity<ReportRunStatusDetails>
    {
        /// <summary>
        /// Error code categorizing the reason the <c>ReportRun</c> failed.
        /// One of: <c>file_size_above_limit</c>, or <c>internal_error</c>.
        /// </summary>
        [JsonProperty("error_code")]
        [STJS.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message with additional details about the failure.
        /// </summary>
        [JsonProperty("error_message")]
        [STJS.JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }
    }
}
