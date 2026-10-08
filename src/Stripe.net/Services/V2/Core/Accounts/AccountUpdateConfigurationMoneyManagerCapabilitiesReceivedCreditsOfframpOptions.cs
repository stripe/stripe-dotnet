// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpOptions : INestedOptions
    {
        /// <summary>
        /// Bank accounts for crypto converted into fiat.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOfframpBankAccountsOptions BankAccounts { get; set; }
    }
}
