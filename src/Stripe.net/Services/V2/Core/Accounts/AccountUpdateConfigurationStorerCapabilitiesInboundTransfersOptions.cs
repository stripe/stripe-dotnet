// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationStorerCapabilitiesInboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Can pull funds from an external bank account owned by yourself to a FinancialAccount.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountUpdateConfigurationStorerCapabilitiesInboundTransfersBankAccountsOptions BankAccounts { get; set; }
    }
}
