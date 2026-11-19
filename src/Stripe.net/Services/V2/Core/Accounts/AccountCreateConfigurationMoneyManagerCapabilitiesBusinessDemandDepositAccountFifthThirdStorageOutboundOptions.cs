// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesBusinessDemandDepositAccountFifthThirdStorageOutboundOptions : INestedOptions
    {
        /// <summary>
        /// Can send funds from business storage FinancialAccounts backed by Fifth Third demand
        /// deposit accounts in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessDemandDepositAccountFifthThirdStorageOutboundUsdOptions Usd { get; set; }
    }
}
