// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionStatusTransitions : StripeEntity<TransactionStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the Transaction changed status to <c>posted</c>.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Timestamp describing when the Transaction changed status to <c>void</c>.
        /// </summary>
        [JsonProperty("void_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? VoidAt { get; set; }
    }
}
