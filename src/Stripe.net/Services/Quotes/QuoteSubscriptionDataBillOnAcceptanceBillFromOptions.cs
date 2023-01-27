// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataBillOnAcceptanceBillFromOptions : INestedOptions
    {
        /// <summary>
        /// Details of a Quote line to start the bill period from.
        /// </summary>
        [JsonProperty("line_starts_at")]
        public QuoteSubscriptionDataBillOnAcceptanceBillFromLineStartsAtOptions LineStartsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// The type of method to specify the <c>bill_from</c> time.
        /// One of: <c>line_starts_at</c>, <c>now</c>, <c>quote_acceptance_date</c>, or
        /// <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
