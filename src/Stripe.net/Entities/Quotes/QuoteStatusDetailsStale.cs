// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusDetailsStale : StripeEntity<QuoteStatusDetailsStale>
    {
        /// <summary>
        /// Time at which the quote expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The most recent reason this quote was marked as stale.
        /// </summary>
        [JsonProperty("last_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_reason")]
#endif
        public QuoteStatusDetailsStaleLastReason LastReason { get; set; }

        /// <summary>
        /// Time at which the stale reason was updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("last_updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_updated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Time at which the quote was marked as stale. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("transitioned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transitioned_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? TransitionedAt { get; set; }
    }
}
