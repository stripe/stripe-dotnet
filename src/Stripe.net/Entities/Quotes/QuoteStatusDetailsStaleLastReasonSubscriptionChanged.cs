// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteStatusDetailsStaleLastReasonSubscriptionChanged : StripeEntity<QuoteStatusDetailsStaleLastReasonSubscriptionChanged>
    {
        /// <summary>
        /// The subscription's state before the quote was marked as stale.
        /// </summary>
        [JsonProperty("previous_subscription")]
        public Subscription PreviousSubscription { get; set; }
    }
}
