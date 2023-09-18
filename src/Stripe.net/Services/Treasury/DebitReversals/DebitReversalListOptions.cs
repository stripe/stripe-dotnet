// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class DebitReversalListOptions : ListOptions
    {
        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return DebitReversals for the ReceivedDebit ID.
        /// </summary>
        [JsonProperty("received_debit")]
        public string ReceivedDebit { get; set; }

        /// <summary>
        /// Only return DebitReversals for a given resolution.
        /// One of: <c>lost</c>, or <c>won</c>.
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// Only return DebitReversals for a given status.
        /// One of: <c>canceled</c>, <c>completed</c>, or <c>processing</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
