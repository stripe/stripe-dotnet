// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteLineSetPauseCollection : StripeEntity<QuoteLineSetPauseCollection>
    {
        /// <summary>
        /// If specified, payment collection for this subscription will be paused. Note that the
        /// subscription status will be unchanged and will not be updated to <c>paused</c>. Learn
        /// more about <a href="https://stripe.com/docs/billing/subscriptions/pause-payment">pausing
        /// collection</a>.
        /// </summary>
        [JsonProperty("set")]
        public QuoteLineSetPauseCollectionSet Set { get; set; }

        /// <summary>
        /// Defines the type of the pause_collection behavior for the quote line.
        /// One of: <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
