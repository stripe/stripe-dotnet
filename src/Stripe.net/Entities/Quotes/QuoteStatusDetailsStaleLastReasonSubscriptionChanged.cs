// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusDetailsStaleLastReasonSubscriptionChanged : StripeEntity<QuoteStatusDetailsStaleLastReasonSubscriptionChanged>
    {
        /// <summary>
        /// The subscription's state before the quote was marked as stale.
        /// </summary>
        [JsonProperty("previous_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("previous_subscription")]
#endif
        public Subscription PreviousSubscription { get; set; }
    }
}
