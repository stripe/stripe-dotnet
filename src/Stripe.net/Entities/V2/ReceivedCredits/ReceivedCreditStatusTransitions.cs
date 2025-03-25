// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditStatusTransitions : StripeEntity<ReceivedCreditStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the ReceivedCredit was marked as <c>failed</c>. Represented as
        /// a RFC 3339 date &amp; time UTC value in millisecond precision, for example:
        /// 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("failed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed_at")]
#endif
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when the ReceivedCredit changed status to <c>returned</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("returned_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned_at")]
#endif
        public DateTime? ReturnedAt { get; set; }

        /// <summary>
        /// Timestamp describing when the ReceivedCredit was marked as <c>succeeded</c>. Represented
        /// as a RFC 3339 date &amp; time UTC value in millisecond precision, for example:
        /// 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("succeeded_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("succeeded_at")]
#endif
        public DateTime? SucceededAt { get; set; }
    }
}
