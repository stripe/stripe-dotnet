// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePhasePauseCollection : StripeEntity<SubscriptionSchedulePhasePauseCollection>
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
    }
}
