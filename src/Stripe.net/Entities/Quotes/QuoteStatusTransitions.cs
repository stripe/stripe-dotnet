// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusTransitions : StripeEntity<QuoteStatusTransitions>
    {
        /// <summary>
        /// The time that the quote was accepted. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonProperty("accepted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accepted_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// The time that the quote was canceled. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// The time that the quote was finalized. Measured in seconds since Unix epoch.
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
    }
}
