// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DebitDisputeStatusTransitions : StripeEntity<DebitDisputeStatusTransitions>
    {
        /// <summary>
        /// The time when the DebitDispute was marked as <c>failed</c>. Represented as a RFC 3339
        /// date &amp; time UTC value in millisecond precision, for example:
        /// <c>2026-04-23T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("failed_at")]
        [STJS.JsonPropertyName("failed_at")]
        public DateTime? FailedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time when the DebitDispute was marked as <c>succeeded</c>. Represented as a RFC 3339
        /// date &amp; time UTC value in millisecond precision, for example:
        /// <c>2026-04-23T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [STJS.JsonPropertyName("succeeded_at")]
        public DateTime? SucceededAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
