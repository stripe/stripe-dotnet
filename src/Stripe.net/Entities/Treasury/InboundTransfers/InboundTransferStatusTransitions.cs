// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferStatusTransitions : StripeEntity<InboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>canceled</c>.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>failed</c>.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>succeeded</c>.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("succeeded_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SucceededAt { get; set; }
    }
}
