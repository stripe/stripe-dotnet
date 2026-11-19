// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessDemandDepositAccountFifthThirdStorageOptions : INestedOptions
    {
        /// <summary>
        /// Can receive funds in business storage FinancialAccounts backed by Fifth Third demand
        /// deposit accounts.
        /// </summary>
        [JsonProperty("inbound")]
        [STJS.JsonPropertyName("inbound")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessDemandDepositAccountFifthThirdStorageInboundOptions Inbound { get; set; }

        /// <summary>
        /// Can send funds from business storage FinancialAccounts backed by Fifth Third demand
        /// deposit accounts.
        /// </summary>
        [JsonProperty("outbound")]
        [STJS.JsonPropertyName("outbound")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessDemandDepositAccountFifthThirdStorageOutboundOptions Outbound { get; set; }
    }
}
