// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InboundTransferStatusTransitions : StripeEntity<InboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>canceled</c>.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>failed</c>.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an InboundTransfer changed status to <c>succeeded</c>.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SucceededAt { get; set; }
    }
}
