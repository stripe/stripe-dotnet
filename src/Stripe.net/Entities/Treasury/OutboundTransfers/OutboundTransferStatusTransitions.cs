// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferStatusTransitions : StripeEntity<OutboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>canceled</c>.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif

        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>failed</c>.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed_at")]
#endif

        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>posted</c>.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
#endif

        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>returned</c>.
        /// </summary>
        [JsonProperty("returned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned_at")]
#endif

        public DateTime? ReturnedAt { get; set; }
    }
}
