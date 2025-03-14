// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusDetailsCanceled : StripeEntity<QuoteStatusDetailsCanceled>
    {
        /// <summary>
        /// The reason this quote was marked as canceled.
        /// One of: <c>canceled</c>, <c>quote_accepted</c>, <c>quote_expired</c>,
        /// <c>quote_superseded</c>, or <c>subscription_canceled</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// Time at which the quote was marked as canceled. Measured in seconds since the Unix
        /// epoch.
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
