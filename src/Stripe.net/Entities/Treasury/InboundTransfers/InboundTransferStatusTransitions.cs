// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferStatusTransitions : StripeEntity<InboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>canceled</c>.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>failed</c>.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("failed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>succeeded</c>.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("succeeded_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? SucceededAt { get; set; }
    }
}
