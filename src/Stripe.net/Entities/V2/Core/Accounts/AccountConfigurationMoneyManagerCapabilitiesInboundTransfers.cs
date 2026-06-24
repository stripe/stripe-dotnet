// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesInboundTransfers : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesInboundTransfers>
    {
        /// <summary>
        /// Can pull funds into a FinancialAccount from an external bank account owned by the user.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountConfigurationMoneyManagerCapabilitiesInboundTransfersBankAccounts BankAccounts { get; set; }
    }
}
