// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class OutboundTransferStatusTransitions : StripeEntity<OutboundTransferStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>canceled</c>.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>failed</c>.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>posted</c>.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Timestamp describing when an OutboundTransfer changed status to <c>returned</c>.
        /// </summary>
        [JsonProperty("returned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReturnedAt { get; set; }
    }
}
