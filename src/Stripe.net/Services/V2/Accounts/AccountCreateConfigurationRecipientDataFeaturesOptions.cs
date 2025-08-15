// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationRecipientDataFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Features that enable OutboundPayments to a bank account linked to this Account.
        /// </summary>
        [JsonProperty("bank_accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_accounts")]
#endif
        public AccountCreateConfigurationRecipientDataFeaturesBankAccountsOptions BankAccounts { get; set; }

        /// <summary>
        /// Feature that enable OutboundPayments to a debit card linked to this Account.
        /// </summary>
        [JsonProperty("cards")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cards")]
#endif
        public AccountCreateConfigurationRecipientDataFeaturesCardsOptions Cards { get; set; }
    }
}
