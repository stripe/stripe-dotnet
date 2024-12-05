// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class CreditReversalListOptions : ListOptions
    {
        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return CreditReversals for the ReceivedCredit ID.
        /// </summary>
        [JsonProperty("received_credit")]
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// Only return CreditReversals for a given status.
        /// One of: <c>canceled</c>, <c>posted</c>, or <c>processing</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
