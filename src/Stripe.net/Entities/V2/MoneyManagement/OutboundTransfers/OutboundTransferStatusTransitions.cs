// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundTransferStatusTransitions : StripeEntity<OutboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>canceled</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>failed</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("failed_at")]
        [STJS.JsonPropertyName("failed_at")]
        public DateTime? FailedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>posted</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("posted_at")]
        [STJS.JsonPropertyName("posted_at")]
        public DateTime? PostedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>returned</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("returned_at")]
        [STJS.JsonPropertyName("returned_at")]
        public DateTime? ReturnedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
