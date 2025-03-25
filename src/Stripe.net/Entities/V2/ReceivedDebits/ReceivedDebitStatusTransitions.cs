// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitStatusTransitions : StripeEntity<ReceivedDebitStatusTransitions>
    {
        /// <summary>
        /// The time when the ReceivedDebit was marked as <c>canceled</c>. Represented as a RFC 3339
        /// date &amp; time UTC value in millisecond precision, for example:
        /// <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("canceled_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// The time when the ReceivedDebit was marked as <c>failed</c>. Represented as a RFC 3339
        /// date &amp; time UTC value in millisecond precision, for example:
        /// <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("failed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed_at")]
#endif
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// The time when the ReceivedDebit was marked as <c>succeeded</c>. Represented as a RFC
        /// 3339 date &amp; time UTC value in millisecond precision, for example:
        /// <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("succeeded_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("succeeded_at")]
#endif
        public DateTime? SucceededAt { get; set; }
    }
}
