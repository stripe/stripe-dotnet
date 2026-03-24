// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteStatusDetailsStale : StripeEntity<QuoteStatusDetailsStale>
    {
        /// <summary>
        /// Time at which the quote expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The most recent reason this quote was marked as stale.
        /// </summary>
        [JsonProperty("last_reason")]
        [STJS.JsonPropertyName("last_reason")]
        public QuoteStatusDetailsStaleLastReason LastReason { get; set; }

        /// <summary>
        /// Time at which the stale reason was updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("last_updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("last_updated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Time at which the quote was marked as stale. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("transitioned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("transitioned_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TransitionedAt { get; set; }
    }
}
