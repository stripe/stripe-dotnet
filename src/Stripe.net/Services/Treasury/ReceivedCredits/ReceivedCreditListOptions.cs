// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedCreditListOptions : ListOptions
    {
        /// <summary>
        /// The FinancialAccount that received the funds.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return ReceivedCredits described by the flow.
        /// </summary>
        [JsonProperty("linked_flows")]
        [STJS.JsonPropertyName("linked_flows")]
        public ReceivedCreditLinkedFlowsOptions LinkedFlows { get; set; }

        /// <summary>
        /// Only return ReceivedCredits that have the given status: <c>succeeded</c> or
        /// <c>failed</c>.
        /// One of: <c>failed</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
