// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPauseCollection : StripeEntity<SubscriptionPauseCollection>
    {
        /// <summary>
        /// The payment collection behavior for this subscription while paused. One of
        /// <c>keep_as_draft</c>, <c>mark_uncollectible</c>, or <c>void</c>.
        /// One of: <c>keep_as_draft</c>, <c>mark_uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("behavior")]
#endif
        public string Behavior { get; set; }

        /// <summary>
        /// The time after which the subscription will resume collecting payments.
        /// </summary>
        [JsonProperty("resumes_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resumes_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ResumesAt { get; set; }
    }
}
