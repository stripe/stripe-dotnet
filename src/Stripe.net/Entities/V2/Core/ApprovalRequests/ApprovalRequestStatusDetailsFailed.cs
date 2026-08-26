// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApprovalRequestStatusDetailsFailed : StripeEntity<ApprovalRequestStatusDetailsFailed>
    {
        /// <summary>
        /// The error code for the failed execution.
        /// </summary>
        [JsonProperty("error_code")]
        [STJS.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message for the failed execution.
        /// </summary>
        [JsonProperty("error_message")]
        [STJS.JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The error type for the failed execution.
        /// </summary>
        [JsonProperty("error_type")]
        [STJS.JsonPropertyName("error_type")]
        public string ErrorType { get; set; }
    }
}
