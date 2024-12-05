// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class InboundTransferListOptions : ListOptions
    {
        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return InboundTransfers that have the given status: <c>processing</c>,
        /// <c>succeeded</c>, <c>failed</c> or <c>canceled</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>processing</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
