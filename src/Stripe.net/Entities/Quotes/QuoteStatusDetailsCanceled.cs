// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteStatusDetailsCanceled : StripeEntity<QuoteStatusDetailsCanceled>
    {
        /// <summary>
        /// The reason this quote was marked as canceled.
        /// One of: <c>canceled</c>, <c>quote_accepted</c>, <c>quote_expired</c>,
        /// <c>quote_superseded</c>, or <c>subscription_canceled</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Time at which the quote was marked as canceled. Measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("transitioned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("transitioned_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TransitionedAt { get; set; }
    }
}
