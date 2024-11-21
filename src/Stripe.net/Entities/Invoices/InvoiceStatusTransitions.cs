// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceStatusTransitions : StripeEntity<InvoiceStatusTransitions>
    {
        /// <summary>
        /// The time that the invoice draft was finalized.
        /// </summary>
        [JsonProperty("finalized_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("finalized_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? FinalizedAt { get; set; }

        /// <summary>
        /// The time that the invoice was marked uncollectible.
        /// </summary>
        [JsonProperty("marked_uncollectible_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marked_uncollectible_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? MarkedUncollectibleAt { get; set; }

        /// <summary>
        /// The time that the invoice was paid.
        /// </summary>
        [JsonProperty("paid_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paid_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// The time that the invoice was voided.
        /// </summary>
        [JsonProperty("voided_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("voided_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? VoidedAt { get; set; }
    }
}
