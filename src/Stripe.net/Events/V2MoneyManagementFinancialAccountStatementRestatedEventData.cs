// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementFinancialAccountStatementRestatedEventData : StripeEntity<V2MoneyManagementFinancialAccountStatementRestatedEventData>
    {
        /// <summary>
        /// The ID of the Financial Account this statement belongs to.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The ID of the new statement that replaces the original.
        /// </summary>
        [JsonProperty("restatement_id")]
        [STJS.JsonPropertyName("restatement_id")]
        public string RestatementId { get; set; }
    }
}
