// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunStatusDetails : StripeEntity<ReportRunStatusDetails>
    {
        /// <summary>
        /// Time at which the run was canceled. Populated when the run is in the <c>canceled</c>
        /// state.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Error code categorizing the reason the run failed.
        /// One of: <c>file_size_above_limit</c>, <c>internal_error</c>, or
        /// <c>query_run_invalid_sql</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Error message with additional details about the failure.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
