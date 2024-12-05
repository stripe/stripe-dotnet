// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferListOptions : ListOptions
    {
        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return OutboundTransfers that have the given status: <c>processing</c>,
        /// <c>canceled</c>, <c>failed</c>, <c>posted</c>, or <c>returned</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
