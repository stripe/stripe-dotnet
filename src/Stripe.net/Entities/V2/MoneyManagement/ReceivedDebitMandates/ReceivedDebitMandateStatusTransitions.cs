// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitMandateStatusTransitions : StripeEntity<ReceivedDebitMandateStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the ReceivedDebitMandate changed status to <c>active</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision.
        /// </summary>
        [JsonProperty("activated_at")]
        [STJS.JsonPropertyName("activated_at")]
        public DateTime? ActivatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when the ReceivedDebitMandate changed status to <c>canceled</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision for
        /// example: 2026-06-03T13:22:18.123Z.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when the ReceivedDebitMandate was created. Represented as a RFC
        /// 3339 date &amp; time UTC value in millisecond precision for example:
        /// 2026-06-03T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created_at")]
        [STJS.JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when the ReceivedDebitMandate changed status to <c>expired</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2026-06-03T13:22:18.123Z.
        /// </summary>
        [JsonProperty("expired_at")]
        [STJS.JsonPropertyName("expired_at")]
        public DateTime? ExpiredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when the ReceivedDebitMandate changed status to
        /// <c>pending_cancellation</c>. Represented as a RFC 3339 date &amp; time UTC value in
        /// millisecond precision.
        /// </summary>
        [JsonProperty("pending_cancellation_at")]
        [STJS.JsonPropertyName("pending_cancellation_at")]
        public DateTime? PendingCancellationAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
