// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditListOptions : ListOptions
    {
        /// <summary>
        /// The FinancialAccount that received the funds.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return ReceivedCredits described by the flow.
        /// </summary>
        [JsonProperty("linked_flows")]
        public ReceivedCreditLinkedFlowsOptions LinkedFlows { get; set; }

        /// <summary>
        /// Only return ReceivedCredits that have the given status: <c>succeeded</c> or
        /// <c>failed</c>.
        /// One of: <c>failed</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
