// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferListOptions : ListOptions
    {
        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return InboundTransfers that have the given status: <c>processing</c>,
        /// <c>succeeded</c>, <c>failed</c> or <c>canceled</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>processing</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
