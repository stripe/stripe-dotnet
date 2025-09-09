// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferStatusTransitions : StripeEntity<OutboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>canceled</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("canceled_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif
        public DateTime CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>failed</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("failed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed_at")]
#endif
        public DateTime FailedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>posted</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("posted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
#endif
        public DateTime PostedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>returned</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("returned_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned_at")]
#endif
        public DateTime ReturnedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
