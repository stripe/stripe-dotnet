// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesInboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Can pull funds from an external bank account owned by yourself to a FinancialAccount.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesInboundTransfersBankAccountsOptions BankAccounts { get; set; }
    }
}
