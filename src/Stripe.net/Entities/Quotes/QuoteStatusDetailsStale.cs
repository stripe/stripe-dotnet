// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteStatusDetailsStale : StripeEntity<QuoteStatusDetailsStale>
    {
        /// <summary>
        /// Time at which the quote expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The most recent reason this quote was marked as stale.
        /// </summary>
        [JsonProperty("last_reason")]
        public QuoteStatusDetailsStaleLastReason LastReason { get; set; }

        /// <summary>
        /// Time at which the stale reason was updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("last_updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Time at which the quote was marked as stale. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("transitioned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TransitionedAt { get; set; }
    }
}
