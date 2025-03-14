// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteComputedLastReestimationDetailsFailed : StripeEntity<QuoteComputedLastReestimationDetailsFailed>
    {
        /// <summary>
        /// The failure <c>code</c> is more granular than the <c>reason</c> provided and may
        /// correspond to a Stripe error code. For automation errors, this field is one of:
        /// <c>reverse_api_failure</c>, <c>reverse_api_deadline_exceeeded</c>, or
        /// <c>reverse_api_response_validation_error</c>, which are Stripe error codes and map to
        /// the error <c>message</c> field.
        /// </summary>
        [JsonProperty("failure_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_code")]
#endif
        public string FailureCode { get; set; }

        /// <summary>
        /// Information derived from the <c>failure_code</c> or a freeform message that explains the
        /// error as a human-readable English string. For example, "margin ID is not a valid ID".
        /// </summary>
        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }

        /// <summary>
        /// The reason the reestimation failed.
        /// One of: <c>automation_failure</c>, or <c>internal_error</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
