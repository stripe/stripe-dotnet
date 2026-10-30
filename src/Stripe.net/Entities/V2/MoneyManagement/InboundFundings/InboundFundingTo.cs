// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundFundingTo : StripeEntity<InboundFundingTo>
    {
        /// <summary>
        /// The amount credited to the destination.
        /// </summary>
        [JsonProperty("credited")]
        [STJS.JsonPropertyName("credited")]
        public V2.Amount Credited { get; set; }

        /// <summary>
        /// The ID of the destination FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }
    }
}
