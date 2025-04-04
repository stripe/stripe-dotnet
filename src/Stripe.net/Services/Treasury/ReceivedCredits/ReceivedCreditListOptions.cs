// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditListOptions : ListOptions
    {
        /// <summary>
        /// The FinancialAccount that received the funds.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return ReceivedCredits described by the flow.
        /// </summary>
        [JsonProperty("linked_flows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("linked_flows")]
#endif
        public ReceivedCreditLinkedFlowsOptions LinkedFlows { get; set; }

        /// <summary>
        /// Only return ReceivedCredits that have the given status: <c>succeeded</c> or
        /// <c>failed</c>.
        /// One of: <c>failed</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
