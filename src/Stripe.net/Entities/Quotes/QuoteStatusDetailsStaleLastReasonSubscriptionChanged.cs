// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteStatusDetailsStaleLastReasonSubscriptionChanged : StripeEntity<QuoteStatusDetailsStaleLastReasonSubscriptionChanged>
    {
        /// <summary>
        /// The subscription's state before the quote was marked as stale.
        /// </summary>
        [JsonProperty("previous_subscription")]
        [STJS.JsonPropertyName("previous_subscription")]
        public Subscription PreviousSubscription { get; set; }
    }
}
