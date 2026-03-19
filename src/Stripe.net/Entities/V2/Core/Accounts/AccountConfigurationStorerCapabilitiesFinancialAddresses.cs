// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesFinancialAddresses : StripeEntity<AccountConfigurationStorerCapabilitiesFinancialAddresses>
    {
        /// <summary>
        /// Can provision a bank-account like financial address (VBAN) to credit/debit a
        /// FinancialAccount.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountConfigurationStorerCapabilitiesFinancialAddressesBankAccounts BankAccounts { get; set; }
    }
}
