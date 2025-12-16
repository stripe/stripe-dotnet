// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationStorerCapabilitiesInboundTransfers : StripeEntity<AccountConfigurationStorerCapabilitiesInboundTransfers>
    {
        /// <summary>
        /// Can pull funds into a FinancialAccount from an external bank account owned by the user.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountConfigurationStorerCapabilitiesInboundTransfersBankAccounts BankAccounts { get; set; }
    }
}
