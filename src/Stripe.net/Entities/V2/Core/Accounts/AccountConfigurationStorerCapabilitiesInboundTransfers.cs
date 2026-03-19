// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerCapabilitiesInboundTransfers : StripeEntity<AccountConfigurationStorerCapabilitiesInboundTransfers>
    {
        /// <summary>
        /// Can pull funds into a FinancialAccount from an external bank account owned by the user.
        /// </summary>
        [JsonProperty("bank_accounts")]
        [STJS.JsonPropertyName("bank_accounts")]
        public AccountConfigurationStorerCapabilitiesInboundTransfersBankAccounts BankAccounts { get; set; }
    }
}
