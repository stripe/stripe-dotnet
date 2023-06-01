// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteLineSetPauseCollection : StripeEntity<QuoteLineSetPauseCollection>
    {
        /// <summary>
        /// If specified, payment collection for this subscription will be paused.
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
