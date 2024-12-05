// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the customer whose quotes will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The subscription which the quote updates.
        /// </summary>
        [JsonProperty("from_subscription")]
        public string FromSubscription { get; set; }

        /// <summary>
        /// The status of the quote.
        /// One of: <c>accepted</c>, <c>accepting</c>, <c>canceled</c>, <c>draft</c>, <c>open</c>,
        /// or <c>stale</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Provides a list of quotes that are associated with the specified test clock. The
        /// response will not include quotes with test clocks if this and the customer parameter is
        /// not set.
        /// </summary>
        [JsonProperty("test_clock")]
        public string TestClock { get; set; }
    }
}
