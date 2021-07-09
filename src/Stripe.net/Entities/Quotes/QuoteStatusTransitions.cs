// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteStatusTransitions : StripeEntity<QuoteStatusTransitions>
    {
        /// <summary>
        /// The time that the quote was accepted. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// The time that the quote was canceled. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// The time that the quote was finalized. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonProperty("finalized_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FinalizedAt { get; set; }
    }
}
