// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountCreditFundedBy : StripeEntity<FinancialAccountCreditFundedBy>
    {
        /// <summary>
        /// Details for platform-funded credit FinancialAccounts.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public FinancialAccountCreditFundedByPlatform Platform { get; set; }

        /// <summary>
        /// The type of funding source for this credit FinancialAccount.
        /// One of: <c>platform</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
