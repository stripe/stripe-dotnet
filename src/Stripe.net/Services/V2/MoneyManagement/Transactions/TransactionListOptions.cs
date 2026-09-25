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
        /// Set of filters to query Transactions within a range of <c>created</c> timestamps.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public TransactionListCreatedOptions Created { get; set; }

        /// <summary>
        /// Filter for Transactions belonging to a FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Filter for Transactions corresponding to a Flow.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public string Flow { get; set; }
    }
}
