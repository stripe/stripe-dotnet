namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceStatusTransitions : StripeEntity<InvoiceStatusTransitions>
    {
        [JsonProperty("finalized_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? FinalizedAt { get; set; }

        [JsonProperty("marked_uncollectible_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? MarkedUncollectibleAt { get; set; }

        [JsonProperty("paid_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? PaidAt { get; set; }

        [JsonProperty("voided_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
