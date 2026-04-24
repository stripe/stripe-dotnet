// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApprovalRequestStatusTransitions : StripeEntity<ApprovalRequestStatusTransitions>
    {
        /// <summary>
        /// Timestamp when the approval request was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp when the approval request expired.
        /// </summary>
        [JsonProperty("expired_at")]
        [STJS.JsonPropertyName("expired_at")]
        public DateTime? ExpiredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp when the approval request failed.
        /// </summary>
        [JsonProperty("failed_at")]
        [STJS.JsonPropertyName("failed_at")]
        public DateTime? FailedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp when the approval request was rejected.
        /// </summary>
        [JsonProperty("rejected_at")]
        [STJS.JsonPropertyName("rejected_at")]
        public DateTime? RejectedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp when the approval request moved to requires_execution status.
        /// </summary>
        [JsonProperty("requires_execution_at")]
        [STJS.JsonPropertyName("requires_execution_at")]
        public DateTime? RequiresExecutionAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp when the approval request succeeded.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [STJS.JsonPropertyName("succeeded_at")]
        public DateTime? SucceededAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
