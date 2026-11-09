// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentStatusTransitions : StripeEntity<PayoutIntentStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when a PayoutIntent changed status to <c>canceled</c>. Represented
        /// as a RFC 3339 date &amp; time UTC value in millisecond precision, for example:
        /// 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when a PayoutIntent changed status to <c>posted</c>. Represented as
        /// a RFC 3339 date &amp; time UTC value in millisecond precision, for example:
        /// 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("posted_at")]
        [STJS.JsonPropertyName("posted_at")]
        public DateTime? PostedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when a PayoutIntent changed status to <c>processing</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("processing_at")]
        [STJS.JsonPropertyName("processing_at")]
        public DateTime? ProcessingAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when a PayoutIntent changed status to <c>requires_action</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("requires_action_at")]
        [STJS.JsonPropertyName("requires_action_at")]
        public DateTime? RequiresActionAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
