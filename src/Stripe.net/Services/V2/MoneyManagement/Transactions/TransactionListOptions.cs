// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for Transactions created within a specified time range.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public TransactionListCreatedOptions Created { get; set; }

        /// <summary>
        /// Filter for Transactions belonging to a specific FinancialAccount. This filter only
        /// supports filtering by the FinancialAccount's ID.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Filter for Transactions created by a specific flow object. This filter only supports
        /// filtering by the flow object's ID, such as <c>ibt_123</c> for an InboundTransfer. A
        /// value that doesn't match a flow ID returns an empty list.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public string Flow { get; set; }
    }
}
