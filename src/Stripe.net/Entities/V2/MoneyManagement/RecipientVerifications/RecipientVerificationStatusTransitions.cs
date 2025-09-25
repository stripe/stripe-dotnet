// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RecipientVerificationStatusTransitions : StripeEntity<RecipientVerificationStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when a RecipientVerification changed status to <c>acknowledged</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("acknowledged_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acknowledged_at")]
#endif
        public DateTime? AcknowledgedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp describing when a RecipientVerification changed status to <c>consumed</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("consumed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consumed_at")]
#endif
        public DateTime? ConsumedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
