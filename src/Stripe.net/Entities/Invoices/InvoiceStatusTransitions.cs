namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceStatusTransitions : StripeEntity<InvoiceStatusTransitions>
    {
        /// <summary>
        /// The time that the invoice draft was finalized.
        /// </summary>
        [JsonProperty("finalized_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FinalizedAt { get; set; }

        /// <summary>
        /// The time that the invoice was marked uncollectible.
        /// </summary>
        [JsonProperty("marked_uncollectible_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? MarkedUncollectibleAt { get; set; }

        /// <summary>
        /// The time that the invoice was paid.
        /// </summary>
        [JsonProperty("paid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// The time that the invoice was voided.
        /// </summary>
        [JsonProperty("voided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
